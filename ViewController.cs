using System;

using AppKit;
using Foundation;
using System.IO;
using System.Diagnostics;

namespace CiscoCommand
{
    public partial class ViewController : NSViewController
    {
        private int subnetMask1 = 0;
        private int subnetMask2 = 0;
        private int subnetMask3 = 0;
        private int subnetMask4 = 0;

        private int nowIFPoint = 1;

        private string nowMode = "exit";



        public ViewController(IntPtr handle) : base(handle)
        {}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            bannerString.StringValue = "Authorized Access Only!";

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
            }
        }

        //コマンド生成処理
        partial void MakeCommand(NSObject sender)
        {
            //保存ファイルの指定
            string appPath = System.Environment.CurrentDirectory;
            Uri u1 = new Uri(appPath);
            Uri u2 = new Uri(u1, "../../command.txt");
            StreamWriter writer = new StreamWriter(@u2.LocalPath);
            writer.WriteLine("");


            if (IsHost.State.Equals(NSCellStateValue.On))//「ホスト名」を選択している時
            {

                if (!HostName.StringValue.Equals(""))//入力が空でない時
                {
                    if (nowMode != "configure terminal")//モード変換用コマンドが必要な場合
                    {
                        nowMode = "configure terminal";
                        writer.WriteLine(nowMode + "\n");//モード変換用コマンドの生成
                    }
                    writer.WriteLine("hostname " + HostName.StringValue);//コマンドをファイルに出力
                }

            }

            if (IsDNS.State.Equals(NSCellStateValue.On))//「DNS lookupの無効」を選択している時
            {
                if (nowMode != "configure terminal")//モード変換用コマンドが必要な場合
                {
                    nowMode = "configure terminal";
                    writer.WriteLine(nowMode + "\n");//モード変換用コマンドの生成
                }
                writer.WriteLine("no ip domain-lookup");//コマンドをファイルに出力
            }

            if (IsEnablePass.State.Equals(NSCellStateValue.On))//「特権パスワード」を選択している時
            {
                
                if (!enablePass.StringValue.Equals(""))//入力が空でない時
                {
                    if (nowMode != "configure terminal")//モード変換用コマンドが必要な場合
                    {
                        nowMode = "configure terminal";
                        writer.WriteLine(nowMode + "\n");//モード変換用コマンドの生成
                    }
                    writer.WriteLine("enable secret " + enablePass.StringValue);//コマンドをファイルに出力
                }


            }

            if (IsBanner.State.Equals(NSCellStateValue.On))//「MOTDバナー」を選択している時
            {
                if (!bannerString.StringValue.Equals(""))//入力が空でない時
                {
                    if (nowMode != "configure terminal")//モード変換用コマンドが必要な場合
                    {
                        nowMode = "configure terminal";
                        writer.WriteLine(nowMode + "\n");//モード変換用コマンドの生成
                    }
                    writer.WriteLine("banner motd \"" + bannerString.StringValue + "\"");//コマンドをファイルに出力
                }
            }

            if (IsConsolePass.State.Equals(NSCellStateValue.On))//「コンソールパスワード」を選択している時
            {
                
                if (!ConsolePass.StringValue.Equals(""))//入力が空でない時
                {
                    if (nowMode != "line console 0")//モード変換用コマンドが必要な場合
                    {
                        nowMode = "line console 0";
                        writer.WriteLine("\n"+nowMode + "\n");//モード変換用コマンドの生成

                    }
                    writer.WriteLine("password " + ConsolePass.StringValue);//コマンドをファイルに出力
                    writer.WriteLine("login");//コマンドをファイルに出力
                }

                
            }
            if (IsConsoleLogging.State.Equals(NSCellStateValue.On))//「ロギングの同期(コンソール)」を選択している時
            {
                if (nowMode != "line console 0")//モード変換用コマンドが必要な場合
                {
                    nowMode = "line console 0";
                    writer.WriteLine("\n" + nowMode + "\n");//モード変換用コマンドの生成

                }
                writer.WriteLine("logging synchronous");//コマンドをファイルに出力
            }

            if (IsVTYPass.State.Equals(NSCellStateValue.On))//「VTYパスワード」を選択している時
            {

                if (!vtyPass.StringValue.Equals(""))//入力が空でない時
                {
                    if (nowMode != "line vty 0 4")//モード変換用コマンドが必要な場合
                    {
                        nowMode = "line vty 0 4";
                        writer.WriteLine("\n" + nowMode + "\n");//モード変換用コマンドの生成

                    }
                    writer.WriteLine("password " + vtyPass.StringValue);//コマンドをファイルに出力
                    writer.WriteLine("login");//コマンドをファイルに出力
                }
            }

            if (IsVTYLogging.State.Equals(NSCellStateValue.On))//「ロギングの同期(VTY)」を選択している時
            {
                if (nowMode != "line vty 0 4")//モード変換用コマンドが必要な場合
                {
                    nowMode = "line vty 0 4";
                    writer.WriteLine("\n" + nowMode + "\n");//モード変換用コマンドの生成

                }
                writer.WriteLine("logging synchronous");//コマンドをファイルに出力
            }

            

            if (nowIFPoint > 1)//IPアドレスリストが存在している時
            {
                for (int i = 1; i < nowIFPoint; i++)
                {
                    PrintIF(writer, i);//IPアドレス用コマンドをファイルに出力
                }
            }

            if (IsSave.State.Equals(NSCellStateValue.On))//「設定の保存」を選択している時
            {
                if (nowMode == "configure terminal")//モード変換用コマンドが必要な場合
                {
                    nowMode = "exit";
                    writer.WriteLine(nowMode + "\n");//モード変換用コマンドの生成
                }
                else if (nowMode != "exit") {//モード変換用コマンドが必要な場合
                    nowMode = "exit";
                    writer.WriteLine("\n" + nowMode + "\n"+nowMode+"\n");//モード変換用コマンドの生成
                }
                writer.WriteLine("copy running-config startup-config");//コマンドをファイルに出力
            }

            writer.Close();
        }

        //IPアドレス用コマンドをファイルに出力する
        private void PrintIF(StreamWriter writer, int i)
        {
            NSTextField IFtmp = null;
            NSTextField IPtmp = null;
            NSTextField Subtmp = null;
            if (i == 1)//リストの1番目を取得
            {
                IFtmp = IFV1;
                IPtmp = IPV1;
                Subtmp = SubV1;
            }
            else if (i == 2)//リストの2番目を取得
            {
                IFtmp = IFV2;
                IPtmp = IPV2;
                Subtmp = SubV2;
            }
            else if (i == 3)//リストの3番目を取得
            {
                IFtmp = IFV3;
                IPtmp = IPV3;
                Subtmp = SubV3;
            }
            else if (i == 4)//リストの4番目を取得
            {
                IFtmp = IFV4;
                IPtmp = IPV4;
                Subtmp = SubV4;
            }

            //コマンドをファイルに出力
            writer.WriteLine("\ninterface " + IFtmp.StringValue);
            writer.WriteLine("ip address " + IPtmp.StringValue + " " + Subtmp.StringValue);
            writer.WriteLine("no shutdown");

        }

        //文字列を数値に変換
        partial void Sub1st(NSPopUpButton sender)
        {
            subnetMask1 = int.Parse(sender.Title);
        }
        partial void Sub2nd(NSPopUpButton sender)
        {
            subnetMask2 = int.Parse(sender.Title);
        }
        partial void Sub3rd(NSPopUpButton sender)
        {
            subnetMask3 = int.Parse(sender.Title);
        }
        partial void Sub4th(NSPopUpButton sender)
        {
            subnetMask4 = int.Parse(sender.Title);
        }

        //IPアドレスリストの追加
        partial void addIPSet(NSObject sender)
        {
            NSTextField IFtmp = null;
            NSTextField IPtmp = null;
            NSTextField Subtmp = null;
            if (nowIFPoint == 1)
            {
                IFtmp = IFV1;
                IPtmp = IPV1;
                Subtmp = SubV1;

            }
            else if (nowIFPoint == 2)
            {
                IFtmp = IFV2;
                IPtmp = IPV2;
                Subtmp = SubV2;
            }
            else if (nowIFPoint == 3)
            {
                IFtmp = IFV3;
                IPtmp = IPV3;
                Subtmp = SubV3;
            }
            else if (nowIFPoint == 4)
            {
                IFtmp = IFV4;
                IPtmp = IPV4;
                Subtmp = SubV4;
            }

            if (IFtmp != null)
            {
                IFtmp.StringValue = IFSelect.SelectedCell.Title;
                IPtmp.StringValue = IP1st.StringValue + "." + IP2nd.StringValue + "." + IP3rd.StringValue + "." + IP4th.StringValue;
                Subtmp.StringValue = subnetMask1 + "." + subnetMask2 + "." + subnetMask3 + "." + subnetMask4;
            }

            nowIFPoint++;
        }

        //選択されているIPアドレスリストの全てを削除
        partial void RemoveIFSet(NSObject sender)
        {
            for (int i = nowIFPoint; i > 0; i--)
            {
                if (cheackRemoveOn(i))//選択されている場合
                {
                    RemoveIF(i);
                    for (int j = i; j < nowIFPoint - 1; j++)
                    {
                        IFOverWrite(j + 1, j);
                    }
                    nowIFPoint--;
                }
            }

            Remove1st.State = NSCellStateValue.Off;
            Remove2nd.State = NSCellStateValue.Off;
            Remove3rd.State = NSCellStateValue.Off;
            Remove4th.State = NSCellStateValue.Off;

        }

        //削除されるIPアドレスリストの確認
        private Boolean cheackRemoveOn(int i)
        {
            if (i == 1 && Remove1st.State.Equals(NSCellStateValue.On))
            {
                return true;
            }
            if (i == 2 && Remove2nd.State.Equals(NSCellStateValue.On))
            {
                return true;
            }
            if (i == 3 && Remove3rd.State.Equals(NSCellStateValue.On))
            {
                return true;
            }
            if (i == 4 && Remove4th.State.Equals(NSCellStateValue.On))
            {
                return true;
            }
            return false;
        }

        //IPアドレスリストの削除
        private void RemoveIF(int i)
        {
            NSTextField IFtmp = null;
            NSTextField IPtmp = null;
            NSTextField Subtmp = null;
            if (i == 1)
            {
                IFtmp = IFV1;
                IPtmp = IPV1;
                Subtmp = SubV1;

            }
            else if (i == 2)
            {
                IFtmp = IFV2;
                IPtmp = IPV2;
                Subtmp = SubV2;
            }
            else if (i == 3)
            {
                IFtmp = IFV3;
                IPtmp = IPV3;
                Subtmp = SubV3;
            }
            else if (i == 4)
            {
                IFtmp = IFV4;
                IPtmp = IPV4;
                Subtmp = SubV4;
            }
            IFtmp.StringValue = "";
            IPtmp.StringValue = "";
            Subtmp.StringValue = "";

        }


        //IPアドレスリストの位置ずらし(上に詰める)
        private void IFOverWrite(int wSorce, int WON)
        {
            NSTextField IFtmp = null;
            NSTextField IPtmp = null;
            NSTextField Subtmp = null;
            String IFStmp = "";
            String IPStmp = "";
            String SubStmp = "";
            if (wSorce == 1)
            {
                IFtmp = IFV1;
                IPtmp = IPV1;
                Subtmp = SubV1;
            }
            else if (wSorce == 2)
            {
                IFtmp = IFV2;
                IPtmp = IPV2;
                Subtmp = SubV2;
            }
            else if (wSorce == 3)
            {
                IFtmp = IFV3;
                IPtmp = IPV3;
                Subtmp = SubV3;
            }
            else if (wSorce == 4)
            {
                IFtmp = IFV4;
                IPtmp = IPV4;
                Subtmp = SubV4;
            }

            IFStmp = IFtmp.StringValue;
            IPStmp = IPtmp.StringValue;
            SubStmp = Subtmp.StringValue;

            RemoveIF(wSorce);

            if (WON == 1)
            {
                IFtmp = IFV1;
                IPtmp = IPV1;
                Subtmp = SubV1;


            }
            else if (WON == 2)
            {
                IFtmp = IFV2;
                IPtmp = IPV2;
                Subtmp = SubV2;
            }
            else if (WON == 3)
            {
                IFtmp = IFV3;
                IPtmp = IPV3;
                Subtmp = SubV3;
            }
            else if (WON == 4)
            {
                IFtmp = IFV4;
                IPtmp = IPV4;
                Subtmp = SubV4;
            }

            IFtmp.StringValue = IFStmp;
            IPtmp.StringValue = IPStmp;
            Subtmp.StringValue = SubStmp;

        }

        public override void ViewDidDisappear()
        {
            Environment.Exit(0);
        }

    }
}
