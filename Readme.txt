Version 1.0 Notes:

- First release.
- User-agent: Scleroglossa/1.0 / Mozilla/5.0 (compatible; Windows) Gecko/60 Firefox/60";
- Features more-or-less the same as ThreeTeeth.
- html5test.com score 477 out of 555.

Todo:

https://developer.mozilla.org/en-US/docs/Mozilla/Gecko/Embedding_Mozilla/FAQ/How_do_I...

Enable right-click in the page -- to copy link, etc.
Anything that opens in a new tab opens a broken window. Handle that gracefully.
Add tabbed browsing.
Get print working -- it kinda works in that it shows a window with print settings like it's gonna print.
Reduce left size border. Right side border is like 1-2 pixels and left is ~5. Also reduce bottom border, goes off the edge. Not sure how many pixels it needs, and may need fewer in the VM.
Don't make all links open in a new window.
Add "save page as". "Query for the nsIWebBrowserPersist interface implemented on the web browser object and call the saveURI() or saveDocument() methods on that. Alternatively, create a standalone webbrowser persist object and call the nsIWebBrowserPersist interface on that to save URIs and documents. This is recommended if you intend anything other than the uri or document your browser is looking at. Register your own nsIWebProgressListener object to listen for progress and state notifications.""
Add "print preview". "Query the web browser object for the nsIWebBrowserPrint interface. Call the nsIWebBrowserPrint::PrintPreview() method supplying a print settings object (e.g. that returned from nsIWebBrowserPrint::GetGlobalPrintSettings()) that you wish to preview the page with. The nsIWebBrowserPrint::PrintPreviewNavigate() method can be used to step through the pages. When finished with preview mode, call nsIWebBrowserPrint::ExitPrintPreview()."

Tasks:

- Examine WbBrowse and copy all of its features.
- Examine TikBew and copy all of its features.
- Dogfood this as my main web browser.
- Examine the docs for the geckofx to see what things I can do with it.

Getting Gecko (required to build):

https://www.technical-recipes.com/2016/using-the-gecko-web-browser-in-a-c-winforms-project/

Basically, go to the nuget console and install geckofx. Uses version 60 for the initial build of this app.
install-package geckofx60.32
