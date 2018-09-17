Imports System.Text

Public Class Class1
    Public Shared Sub Main
        Dim htmlEncoding as String = "Hello&sp;World&excl;"
        Dim asciiEncoding as String = ConvertHtmlCharactersToAsciiCharacters(htmlEncoding)
        Console.Write(asciiEncoding)
    End Sub
    Private Shared Function ConvertHtmlCharactersToAsciiCharacters(s As String) As String
        Dim sb As New StringBuilder(s)

        sb.Replace(vbCrLf, "")
        sb.Replace("&shy;", "")

        sb.Replace("&sp;", ChrW(32))
        sb.Replace("&excl;", ChrW(33))
        sb.Replace("&quot;", ChrW(34))
        sb.Replace("&num;", ChrW(35))
        sb.Replace("&dollar;", ChrW(36))
        sb.Replace("&percent;", ChrW(37))
        sb.Replace("&amp;", ChrW(38))
        sb.Replace("&apos;", ChrW(39))

        sb.Replace("&lpar;", ChrW(40))
        sb.Replace("&rpar;", ChrW(41))
        sb.Replace("&ast;", ChrW(42))
        sb.Replace("&plus;", ChrW(43))
        sb.Replace("&comma;", ChrW(44))
        sb.Replace("&minus;", ChrW(45))
        sb.Replace("&hyphen;", ChrW(45))
        sb.Replace("&period;", ChrW(46))
        sb.Replace("&frasl;", ChrW(47))
        sb.Replace("&sol;", ChrW(47))

        'Chrw(48-57) lowercase alphanumberic

        sb.Replace("&colon;", ChrW(58))
        sb.Replace("&semi;", ChrW(59))

        sb.Replace("&lt;", ChrW(60))
        sb.Replace("&equals;", ChrW(61))
        sb.Replace("&gt;", ChrW(62))
        sb.Replace("&quest;", ChrW(63))
        sb.Replace("&commat;", ChrW(64))

        'Chrw(65-90) lowercase alphanumberic

        sb.Replace("&lbrack;", ChrW(91))
        sb.Replace("&lsqb;", ChrW(91))
        sb.Replace("&bsol;", ChrW(92))
        sb.Replace("&rbrack;", ChrW(93))
        sb.Replace("&rsqb;", ChrW(93))
        sb.Replace("&Hat;", ChrW(94))
        sb.Replace("&circ;", ChrW(94))
        sb.Replace("&lowbar;", ChrW(95))
        sb.Replace("&horbar;", ChrW(95))
        sb.Replace("&grave;", ChrW(96))
        'Chrw(97-122) lowercase alphanumberic

        sb.Replace("&lbrace;", ChrW(123))
        sb.Replace("&lcub;", ChrW(123))
        sb.Replace("&vert;", ChrW(124))
        sb.Replace("&verbar;", ChrW(124))
        sb.Replace("&rbrace;", ChrW(125))
        sb.Replace("&rcub;", ChrW(125))
        sb.Replace("&tilde;", ChrW(126))

        'Chrw(127) Delete, No equiv in html

        sb.Replace("&Ccedil;", ChrW(128))
        sb.Replace("&ucirc;", ChrW(129))

        sb.Replace("&eacute;", ChrW(130))
        sb.Replace("&acirc;", ChrW(131))
        sb.Replace("&auml;", ChrW(132))
        sb.Replace("&agrave;", ChrW(133))
        sb.Replace("&aring;", ChrW(134))
        sb.Replace("&ccedil;", ChrW(135))
        sb.Replace("&ecirc;", ChrW(136))
        sb.Replace("&euml;", ChrW(137))
        sb.Replace("&egrave;", ChrW(138))
        sb.Replace("&iuml;", ChrW(139))

        sb.Replace("&icirc;", ChrW(140))
        sb.Replace("&igrave;", ChrW(141))
        sb.Replace("&Auml;", ChrW(142))
        sb.Replace("&Aring;", ChrW(143))
        sb.Replace("&Eacute;", ChrW(144))
        sb.Replace("&aelig;", ChrW(145))
        sb.Replace("&AElig;", ChrW(146))
        sb.Replace("&ocirc;", ChrW(147))
        sb.Replace("&ouml;", ChrW(148))
        sb.Replace("&ograve;", ChrW(149))

        sb.Replace("&ucirc;", ChrW(150))
        sb.Replace("&ugrave;", ChrW(151))
        sb.Replace("&yuml;", ChrW(152))
        sb.Replace("&Ouml;", ChrW(153))
        sb.Replace("&Uuml;", ChrW(154))
        sb.Replace("&oslash;", ChrW(155))
        sb.Replace("&pound;", ChrW(156))
        sb.Replace("&Oslash;", ChrW(157))
        sb.Replace("&times;", ChrW(158))
        sb.Replace("&fnof;", ChrW(159))

        sb.Replace("&aacute;", ChrW(160))
        sb.Replace("&iacute;", ChrW(161))
        sb.Replace("&oacute;", ChrW(162))
        sb.Replace("&uacute;", ChrW(163))
        sb.Replace("&ntilde;", ChrW(164))
        sb.Replace("&Ntilde;", ChrW(165))
        sb.Replace("&ordf;", ChrW(166))
        sb.Replace("&ordm;", ChrW(167))
        sb.Replace("&iquest;", ChrW(168))
        sb.Replace("&reg;", ChrW(169))

        sb.Replace("&not;", ChrW(170))
        sb.Replace("&frac12;", ChrW(171))
        sb.Replace("&half;", ChrW(171))
        sb.Replace("&frac14;", ChrW(172))
        sb.Replace("&iexcl;", ChrW(173))
        sb.Replace("&laquo;", ChrW(174))
        sb.Replace("&raquo;", ChrW(175))
        sb.Replace("&blk14;", ChrW(176))
        sb.Replace("&blk12;", ChrW(177))
        sb.Replace("&blk34;", ChrW(178))
        sb.Replace("&boxv;", ChrW(179))

        sb.Replace("&boxvl;", ChrW(180))
        sb.Replace("&Aacute;", ChrW(181))
        sb.Replace("&Acirc;", ChrW(182))
        sb.Replace("&Agrave;", ChrW(183))
        sb.Replace("&copy;", ChrW(184))
        sb.Replace("&boxVL;", ChrW(185))
        sb.Replace("&boxV;", ChrW(186))
        sb.Replace("&boxDL;", ChrW(187))
        sb.Replace("&boxUL;", ChrW(188))
        sb.Replace("&cent;", ChrW(189))

        sb.Replace("&yen;", ChrW(190))
        sb.Replace("&boxdl;", ChrW(191))
        'Chrw(192) - Chrw(197) are box drawing characters
        sb.Replace("&atilde;", ChrW(198))
        sb.Replace("&Atilde;", ChrW(199))

        'Chrw(200) - Chrw(206) are box drawing characters
        sb.Replace("&curren;", ChrW(207))
        sb.Replace("&eth;", ChrW(208))
        sb.Replace("&ETH;", ChrW(209))
        sb.Replace("&Dstrok;", ChrW(209))

        sb.Replace("&Ecirc;", ChrW(210))
        sb.Replace("&Euml;", ChrW(211))
        sb.Replace("&Egrave;", ChrW(212))
        'Chrw(213) - lowercase dot less i has no html equiv
        sb.Replace("&lacute;", ChrW(214))
        sb.Replace("&lcirc;", ChrW(215))
        sb.Replace("&luml;", ChrW(216))
        'Chrw(217) - Chrw(218) are box drawing characters
        sb.Replace("&block;", ChrW(219))

        sb.Replace("&lhblk;", ChrW(220))
        sb.Replace("&brvbar;", ChrW(221))
        sb.Replace("&brkbar;", ChrW(221))
        sb.Replace("&lgrave;", ChrW(222))
        sb.Replace("&uhblk;", ChrW(223))
        sb.Replace("&Oacute;", ChrW(224))
        sb.Replace("&szlig;", ChrW(225))
        sb.Replace("&Ocirc;", ChrW(226))
        sb.Replace("&Ograve;", ChrW(227))
        sb.Replace("&otilde;", ChrW(228))
        sb.Replace("&Otilde;", ChrW(229))

        sb.Replace("&micro;", ChrW(230))
        sb.Replace("&thorn;", ChrW(231))
        sb.Replace("&THORN;", ChrW(232))
        sb.Replace("&Uacute;", ChrW(233))
        sb.Replace("&Ucirc;", ChrW(234))
        sb.Replace("&Ugrave;", ChrW(235))
        sb.Replace("&yacute;", ChrW(236))
        sb.Replace("&Yacute;", ChrW(237))
        sb.Replace("&macr;", ChrW(238))
        sb.Replace("&hibar;", ChrW(238))
        sb.Replace("&acute;", ChrW(239))

        sb.Replace("&equiv;", ChrW(240))
        sb.Replace("&plusmn;", ChrW(241))
        'ChrW(242) Double Underline , no html equiv
        sb.Replace("&frac34;", ChrW(243))
        sb.Replace("&para;", ChrW(244))
        sb.Replace("&sect;", ChrW(245))
        sb.Replace("&divide;", ChrW(246))
        sb.Replace("&cedil;", ChrW(247))
        sb.Replace("&deg;", ChrW(248))
        sb.Replace("&uml;", ChrW(249))
        sb.Replace("&die;", ChrW(249))

        sb.Replace("&middot;", ChrW(250))
        sb.Replace("&sup1;", ChrW(251))
        sb.Replace("&sup3;", ChrW(252))
        sb.Replace("&sup2;", ChrW(253))
        sb.Replace("&spuf;", ChrW(254))
        sb.Replace("&nbsp;", ChrW(255))

        Return sb.ToString()
    End Function
End Class