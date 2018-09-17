# ConvertHtmlCharCodesToAsciiCharCodes
> Converts Html Char Codes to Ascii Char Codes

Today I discovered the Asset Model Builder doesn't play well with hard coded Extended ascii characters.
I had to change a lot of µ to Chrw(230) and such. That's called a micro, by the way.
Since I had to do half of them, I figured I'd do the other half too and share it with hopes no one else has to do it.


## What this function does:
Given a String potentially containing HtmlCharacterCodes, such as &mico;, &szlig;, or even &sp;
This function safely changes those special character codes to extended ascii codes.
It uses StringBuilder because strings are immutable values. This will maximize performance.
