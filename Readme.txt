Version 1.0 Notes:

- First release.
- User-agent: Scleroglossa/1.0 / Mozilla/5.0 (compatible; Windows) Gecko/60 Firefox/60";
- Features more-or-less the same as ThreeTeeth.
- html5test.com score 477 out of 555.

Todo:

Fix window artifacts on resize -- seems to be border of input box and/or go button.
Enable right-click in the page -- to copy link, etc.
Anything that opens in a new tab opens a broken window. Handle that gracefully.
Add tabbed browsing.
Create an icon that is a gecko's hand and place it in all windows.
Create a v1.0 installer that is just the single tab version.
Get print working.
Get drag and drop of html files working.
Reduce left size border. Right side border is like 1-2 pixels and left is ~5. Also reduce bottom border, goes off the edge. Not sure how many pixels it needs, and may need fewer in the VM.
Make sure application is DPI aware - be sure it resizes when dragging across monitors. Add manifest setting if needed.
Don't make all links open in a new window.

Tasks:

- Examine WbBrowse and copy all of its features.
- Examine TikBew and copy all of its features.
- Dogfood this as my main web browser.
- Examine the docs for the geckofx to see what things I can do with it.

Getting Gecko (required to build):

https://www.technical-recipes.com/2016/using-the-gecko-web-browser-in-a-c-winforms-project/

Basically, go to the nuget console and install geckofx. Uses version 60 for the initial build of this app.
install-package geckofx60.32