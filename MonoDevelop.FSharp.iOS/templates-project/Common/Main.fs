namespace ${Namespace}

open System
open MonoTouch.Foundation
open MonoTouch.UIKit

module main =

    [<EntryPoint>]
    let main (args) =
        UIApplication.Main (args, null, "AppDelegate")
        0