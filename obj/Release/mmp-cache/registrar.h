#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>

@class __monomac_internal_ActionDispatcher;
@class NSApplicationDelegate;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class __NSGestureRecognizerToken;
@class __NSGestureRecognizerParameterlessToken;
@class __NSGestureRecognizerParametrizedToken;
@class __NSClickGestureRecognizer;
@class __NSMagnificationGestureRecognizer;
@class __NSPanGestureRecognizer;
@class __NSPressGestureRecognizer;
@class __NSRotationGestureRecognizer;
@class __NSObject_Disposer;
@class AppDelegate;
@class ViewController;

@interface NSApplicationDelegate : NSObject<NSApplicationDelegate> {
}
	-(id) init;
@end

@interface __NSGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __NSGestureRecognizerParameterlessToken : __NSGestureRecognizerToken {
}
	-(void) target;
@end

@interface __NSGestureRecognizerParametrizedToken : __NSGestureRecognizerToken {
}
	-(void) target:(NSGestureRecognizer *)p0;
@end

@interface AppDelegate : NSObject<NSApplicationDelegate, NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface ViewController : NSViewController {
}
	@property (nonatomic, assign) NSTextField * bannerString;
	@property (nonatomic, assign) NSTextField * ConsolePass;
	@property (nonatomic, assign) NSTextField * enablePass;
	@property (nonatomic, assign) NSTextField * HostName;
	@property (nonatomic, assign) NSMatrix * IFSelect;
	@property (nonatomic, assign) NSTextField * IFV1;
	@property (nonatomic, assign) NSTextField * IFV2;
	@property (nonatomic, assign) NSTextField * IFV3;
	@property (nonatomic, assign) NSTextField * IFV4;
	@property (nonatomic, assign) NSTextField * IP1st;
	@property (nonatomic, assign) NSTextField * IP2nd;
	@property (nonatomic, assign) NSTextField * IP3rd;
	@property (nonatomic, assign) NSTextField * IP4th;
	@property (nonatomic, assign) NSTextField * IPV1;
	@property (nonatomic, assign) NSTextField * IPV2;
	@property (nonatomic, assign) NSTextField * IPV3;
	@property (nonatomic, assign) NSTextField * IPV4;
	@property (nonatomic, assign) NSButton * IsBanner;
	@property (nonatomic, assign) NSButton * IsConsoleLogging;
	@property (nonatomic, assign) NSButton * IsConsolePass;
	@property (nonatomic, assign) NSButton * IsDNS;
	@property (nonatomic, assign) NSButton * IsEnablePass;
	@property (nonatomic, assign) NSButton * IsHost;
	@property (nonatomic, assign) NSButton * IsSave;
	@property (nonatomic, assign) NSButton * IsVTYLogging;
	@property (nonatomic, assign) NSButton * IsVTYPass;
	@property (nonatomic, assign) NSButton * Remove1st;
	@property (nonatomic, assign) NSButton * Remove2nd;
	@property (nonatomic, assign) NSButton * Remove3rd;
	@property (nonatomic, assign) NSButton * Remove4th;
	@property (nonatomic, assign) NSTextField * SubV1;
	@property (nonatomic, assign) NSTextField * SubV2;
	@property (nonatomic, assign) NSTextField * SubV3;
	@property (nonatomic, assign) NSTextField * SubV4;
	@property (nonatomic, assign) NSButton * testck;
	@property (nonatomic, assign) NSTextField * testlabel;
	@property (nonatomic, assign) NSTextField * vtyPass;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSTextField *) bannerString;
	-(void) setBannerString:(NSTextField *)p0;
	-(NSTextField *) ConsolePass;
	-(void) setConsolePass:(NSTextField *)p0;
	-(NSTextField *) enablePass;
	-(void) setEnablePass:(NSTextField *)p0;
	-(NSTextField *) HostName;
	-(void) setHostName:(NSTextField *)p0;
	-(NSMatrix *) IFSelect;
	-(void) setIFSelect:(NSMatrix *)p0;
	-(NSTextField *) IFV1;
	-(void) setIFV1:(NSTextField *)p0;
	-(NSTextField *) IFV2;
	-(void) setIFV2:(NSTextField *)p0;
	-(NSTextField *) IFV3;
	-(void) setIFV3:(NSTextField *)p0;
	-(NSTextField *) IFV4;
	-(void) setIFV4:(NSTextField *)p0;
	-(NSTextField *) IP1st;
	-(void) setIP1st:(NSTextField *)p0;
	-(NSTextField *) IP2nd;
	-(void) setIP2nd:(NSTextField *)p0;
	-(NSTextField *) IP3rd;
	-(void) setIP3rd:(NSTextField *)p0;
	-(NSTextField *) IP4th;
	-(void) setIP4th:(NSTextField *)p0;
	-(NSTextField *) IPV1;
	-(void) setIPV1:(NSTextField *)p0;
	-(NSTextField *) IPV2;
	-(void) setIPV2:(NSTextField *)p0;
	-(NSTextField *) IPV3;
	-(void) setIPV3:(NSTextField *)p0;
	-(NSTextField *) IPV4;
	-(void) setIPV4:(NSTextField *)p0;
	-(NSButton *) IsBanner;
	-(void) setIsBanner:(NSButton *)p0;
	-(NSButton *) IsConsoleLogging;
	-(void) setIsConsoleLogging:(NSButton *)p0;
	-(NSButton *) IsConsolePass;
	-(void) setIsConsolePass:(NSButton *)p0;
	-(NSButton *) IsDNS;
	-(void) setIsDNS:(NSButton *)p0;
	-(NSButton *) IsEnablePass;
	-(void) setIsEnablePass:(NSButton *)p0;
	-(NSButton *) IsHost;
	-(void) setIsHost:(NSButton *)p0;
	-(NSButton *) IsSave;
	-(void) setIsSave:(NSButton *)p0;
	-(NSButton *) IsVTYLogging;
	-(void) setIsVTYLogging:(NSButton *)p0;
	-(NSButton *) IsVTYPass;
	-(void) setIsVTYPass:(NSButton *)p0;
	-(NSButton *) Remove1st;
	-(void) setRemove1st:(NSButton *)p0;
	-(NSButton *) Remove2nd;
	-(void) setRemove2nd:(NSButton *)p0;
	-(NSButton *) Remove3rd;
	-(void) setRemove3rd:(NSButton *)p0;
	-(NSButton *) Remove4th;
	-(void) setRemove4th:(NSButton *)p0;
	-(NSTextField *) SubV1;
	-(void) setSubV1:(NSTextField *)p0;
	-(NSTextField *) SubV2;
	-(void) setSubV2:(NSTextField *)p0;
	-(NSTextField *) SubV3;
	-(void) setSubV3:(NSTextField *)p0;
	-(NSTextField *) SubV4;
	-(void) setSubV4:(NSTextField *)p0;
	-(NSButton *) testck;
	-(void) setTestck:(NSButton *)p0;
	-(NSTextField *) testlabel;
	-(void) setTestlabel:(NSTextField *)p0;
	-(NSTextField *) vtyPass;
	-(void) setVtyPass:(NSTextField *)p0;
	-(void) viewDidLoad;
	-(NSObject *) representedObject;
	-(void) setRepresentedObject:(NSObject *)p0;
	-(void) viewDidDisappear;
	-(void) addIPSet:(NSObject *)p0;
	-(void) MakeCommand:(NSObject *)p0;
	-(void) RemoveIFSet:(NSObject *)p0;
	-(void) Sub1st:(NSPopUpButton *)p0;
	-(void) Sub2nd:(NSPopUpButton *)p0;
	-(void) Sub3rd:(NSPopUpButton *)p0;
	-(void) Sub4th:(NSPopUpButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end


