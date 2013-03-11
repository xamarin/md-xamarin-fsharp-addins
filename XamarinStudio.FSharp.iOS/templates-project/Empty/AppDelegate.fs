namespace ${Namespace}

    open System
    open MonoTouch.Foundation
    open MonoTouch.UIKit

    [<Register ("AppDelegate")>]
    type AppDelegate () =
        inherit UIApplicationDelegate ()

        [<DefaultValue>]
        val mutable window : UIWindow

        override x.FinishedLaunching (app, options) =
            let window = new UIWindow (UIScreen.MainScreen.Bounds)
            window.MakeKeyAndVisible (x)
            true
