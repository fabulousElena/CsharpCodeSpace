var System = {
    getElementsByName: function(tag, eltname) {
        var elts = document.getElementsByTagName(tag);
        var count = 0;
        var elements = [];
        for (var i = 0; i < elts.length; i++) {
            if (elts[i].getAttribute("name") == eltname) {
                elements[count++] = elts[i];
            }
        }
        return elements;
    },
    build: function() {
        var music_players = System.getElementsByName("span", "music_player");
        if (music_players.length == 0)
            return;
        var isIE = (navigator.appVersion.indexOf("MSIE") != -1) ? true : false;
        var play_canvas;
        var element_value;
        var player;
        var pInfo;

        // app script
        //var oscript = document.createElement("script");
        //oscript.src = "http://music.tianya.cn/hi.htm";
        //document.body.appendChild(oscript);

        for (var idx = 0; idx < music_players.length; idx++) {
            element_value = music_players[idx].getAttribute("value");
            player = Player.parse(element_value);
            pInfo = Player.playerInfo[player.playname];

            if (pInfo == null) {
                pInfo = Player.playerInfo["default"];
            };
            if (isIE) {
                music_players[idx].innerHTML = '<OBJECT id="iMusicPlayer" name="iMusicPlayer" type="application/x-shockwave-flash" width="' + pInfo.width + '" height="' + pInfo.height + '" align="middle" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" name="app"><PARAM value="' + pInfo.playerUrl + '" name="movie" /><PARAM value="transparent" name="wmode" /><PARAM value="high" name="quality" /><PARAM value="#000000" name="bgcolor" /><PARAM value="always" name="allowScriptAccess" /><param name="FlashVars" value="' + player.toString() + '"/></OBJECT>';
            } else {
                music_players[idx].innerHTML = '<embed id="iMusicPlayer" name="iMusicPlayer" width="' + pInfo.width + '" height="' + pInfo.height + '" align="middle" type="application/x-shockwave-flash" salign="" allowscriptaccess="always" allowfullscreen="false" menu="true" bgcolor="#ffffff" devicefont="false" wmode="window" scale="showall" flashvars="' + player.toString() + '" loop="true" play="true" pluginspage="http://www.macromedia.com/go/getflashplayer" quality="high" src="' + pInfo.playerUrl + '"/>';
            };
        }
    }
};
var Music = function() {
    this.musicId;
    this.author;
    this.toString = function() {
        return "musicId=" + this.musicId + "&username=" + this.author;
    }
};
var Album = function() {
    this.albumId;
    this.albumname;
    this.toString = function() {
        return "albumId=" + this.albumId + "&albumname=" + this.albumname;
    }
};
var Player = function() {
    this.playername;
    this.album = null;
    this.autostart;
    this.source;

    this.toString = function() {
        var str;
        if (this.source instanceof Music) {
            str = this.source.toString() + "&autostart=" + this.autostart;
        } else {
            str = "targetUrl=" + this.source + "&username=天涯音乐&musicId=0" + "&autostart=" + this.autostart;
        };
        
        if (this.album != null) {
            str += "&albumId=" + this.album.albumId + "&albumname=" + this.album.albumname;
        };
        return str;
    }
};
Player.parse = function(value) {
    var play = new Player();
    var params = value.split(",");

    if (params.length == 0) {
        throw "数据格式不正确";
    } else if (params.length == 1) {
        play.playname = "imusica2";
        play.source = params[0];
        play.autostart = "true";
    } else {
        var music = new Music();
        music.musicId = params[3];
        music.author = params[4];
        
        var album = new Album();
        album.albumId = params[1];
        album.albumname = params[2];

        play.playname = params[0];
        play.source = music;
        play.album = album;
        play.autostart = params[5];
        // _debug
//        var mid = parseInt(music.musicId);
//        if (mid == 47811 || mid == 280110 || mid == 226993 || mid == 261245 || mid == 365863 || mid == 367730) {
//            try { Logger.info(window.location.toString() + "_" + music.musicId + "_" + music.author); } catch (e) { };
//        }
        // end _debug
    };
    return play;
};
Player.playerInfo = ({
"default": { playerUrl: "http://music1.tianya.cn/irok/apps/iMusicA/iMusicA2.swf", width: 170, height: 60 },
"imusica": { playerUrl: "http://music2.tianya.cn/irok/apps/iMusicA/iMusicA.swf", width: 403, height: 60 },
"imusica2": { playerUrl: "http://music1.tianya.cn/irok/apps/iMusicA/iMusicA2.swf", width: 170, height: 60 }
});
var Logger = function () {
};
Logger.info = function (v) {
    var iframe = document.createElement("iframe");
    var url = "http://tempad.tianya.cn/rock/process/sarticle.asp?categoryId=15&Summary=" + v;
    iframe.setAttribute("src", url);
    jQuery(document).ready(function () {
        document.body.appendChild(iframe);
    });
};
try {System.build();} catch(e){}