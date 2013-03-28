namespace ${Namespace}

open System
open System.Drawing

open MonoTouch.UIKit
open MonoTouch.Foundation

[<Register ("${SafeProjectName}ViewController")>]
type ${SafeProjectName}ViewController () =
    inherit UIViewController ()

    override x.DidReceiveMemoryWarning () =
    // Releases the view if it doesn't have a superview.
        base.DidReceiveMemoryWarning ()
        // Release any cached data, images, etc that aren't in use.

    override x.ViewDidLoad () =
        base.ViewDidLoad ()
        // Perform any additional setup after loading the view, typically from a nib.

    override x.ShouldAutorotateToInterfaceOrientation (toInterfaceOrientation) =
        // Return true for supported orientations
        true
