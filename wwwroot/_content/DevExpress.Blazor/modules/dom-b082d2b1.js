import{_ as e}from"./_tslib-1f2a369a.js";var t=function(){function e(){}return e.IdentUserAgent=function(t,r){void 0===r&&(r=!1);var n=["Mozilla","IE","Firefox","Netscape","Safari","Chrome","Opera","Opera10","Edge"],o="IE",i="Win",u={Safari:2,Chrome:.1,Mozilla:1.9,Netscape:8,Firefox:2,Opera:9,IE:6,Edge:12};if(t&&0!==t.length){t=t.toLowerCase(),e.indentPlatformMajorVersion(t);try{for(var a={Windows:"Win",Macintosh:"Mac","Mac OS":"Mac",Mac_PowerPC:"Mac","cpu os":"MacMobile","cpu iphone os":"MacMobile",Android:"Android","!Windows Phone":"WinPhone","!WPDesktop":"WinPhone","!ZuneWP":"WinPhone"},l="(\\d+)(?:\\.((?:\\d+?[1-9])|\\d)0*?)?",s="(?:"+l+")?",f={Safari:"applewebkit(?:.*?(?:version/"+l+"[\\.\\w\\d]*?(?:\\s+mobile/\\S*)?\\s+safari))?",Chrome:"(?:chrome|crios)(?!frame)(?:/|\\s*)?"+s,Mozilla:"mozilla(?:.*rv:"+s+".*Gecko)?",Netscape:"(?:netscape|navigator)\\d*/?\\s*"+s,Firefox:"firefox(?:/|\\s*)?"+s,Opera:"(?:opera|\\sopr)(?:/|\\s*)?"+s,Opera10:"opera.*\\s*version(?:/|\\s*)?"+s,IE:"msie\\s*"+s,Edge:"edge(?:/|\\s*)?"+s},c=null,d=-1,m=0;m<n.length;m++){var v=n[m],h=new RegExp(f[v],"i").exec(t);if(h&&h.index>=0){if("IE"===c&&d>=11&&"Safari"===v)continue;"Opera10"===(c=v)&&(c="Opera");d=e.GetBrowserVersion(t,h,"trident(?:/|\\s*)?(?:(\\d+)(?:\\.((?:\\d+?[1-9])|\\d)0*?)?)?",e.getIECompatibleVersionString()),"Mozilla"===c&&d>=11&&(c="IE")}}c||(c=o);var g=-1!==d;g||(d=u[c]);var p=null,x=Number.MAX_VALUE;for(var y in a)if(Object.prototype.hasOwnProperty.call(a,y)){var w="!"===y.substr(0,1),b=t.indexOf((w?y.substr(1):y).toLowerCase());b>=0&&(b<x||w)&&(x=w?0:b,p=a[y])}var M=t.toUpperCase().match("SM-[A-Z]"),E=M&&M.length>0;"WinPhone"===p&&d<9&&(d=Math.floor(e.getVersionFromTrident(t,"trident(?:/|\\s*)?"+s))),!r&&"IE"===c&&d>7&&document.documentMode<d&&(d=document.documentMode),"WinPhone"===p&&(d=Math.max(9,d)),p||(p=i),p!==a["cpu os"]||g||(d=4),e.fillUserAgentInfo(n,c,d,p,E)}catch(t){e.fillUserAgentInfo(n,o,u.IE,i)}}else e.fillUserAgentInfo(n,o,u.IE,i)},e.GetBrowserVersion=function(t,r,n,o){var i=e.getVersionFromMatches(r);if(o){var u=e.getVersionFromTrident(t,n);if("edge"===o||parseInt(o)===u)return u}return i},e.getIECompatibleVersionString=function(){if(document.compatible)for(var e=0;e<document.compatible.length;e++)if("IE"===document.compatible[e].userAgent&&document.compatible[e].version)return document.compatible[e].version.toLowerCase();return""},e.isTouchEnabled=function(){return e.hasTouchStart()||e.hasMaxTouchPoints()||e.hasMsMaxTouchPoints()},e.hasTouchStart=function(){return"ontouchstart"in window},e.hasMaxTouchPoints=function(){return navigator.maxTouchPoints>0},e.hasMsMaxTouchPoints=function(){return navigator.msMaxTouchPoints>0},e.hasNavigator=function(){return"undefined"!=typeof navigator},e.fillUserAgentInfo=function(t,r,n,o,i){void 0===i&&(i=!1);for(var u=0;u<t.length;u++){var a=t[u];e[a]=a===r}e.Version=Math.floor(10*n)/10,e.MajorVersion=Math.floor(e.Version),e.WindowsPlatform="Win"===o||"WinPhone"===o,e.MacOSMobilePlatform="MacMobile"===o||"Mac"===o&&e.isTouchEnabled(),e.MacOSPlatform="Mac"===o&&!e.MacOSMobilePlatform,e.AndroidMobilePlatform="Android"===o,e.WindowsPhonePlatform="WinPhone"===o,e.WebKitFamily=e.Safari||e.Chrome||e.Opera&&e.MajorVersion>=15,e.NetscapeFamily=e.Netscape||e.Mozilla||e.Firefox,e.HardwareAcceleration=e.IE&&e.MajorVersion>=9||e.Firefox&&e.MajorVersion>=4||e.AndroidMobilePlatform&&e.Chrome||e.Chrome&&e.MajorVersion>=37||e.Safari&&!e.WindowsPlatform||e.Edge||e.Opera&&e.MajorVersion>=46,e.WebKitTouchUI=e.MacOSMobilePlatform||e.AndroidMobilePlatform;var l=e.IE&&e.MajorVersion>9&&e.WindowsPlatform&&e.UserAgent.toLowerCase().indexOf("touch")>=0;if(e.MSTouchUI=l||e.Edge&&!!window.navigator.maxTouchPoints,e.TouchUI=e.WebKitTouchUI||e.MSTouchUI,e.MobileUI=e.WebKitTouchUI||e.WindowsPhonePlatform,e.AndroidDefaultBrowser=e.AndroidMobilePlatform&&!e.Chrome,e.AndroidChromeBrowser=e.AndroidMobilePlatform&&e.Chrome,i&&(e.SamsungAndroidDevice=i),e.MSTouchUI){var s=e.UserAgent.toLowerCase().indexOf("arm;")>-1;e.VirtualKeyboardSupported=s||e.WindowsPhonePlatform}else e.VirtualKeyboardSupported=e.WebKitTouchUI;e.fillDocumentElementBrowserTypeClassNames(t)},e.indentPlatformMajorVersion=function(t){var r=/(?:(?:windows nt|macintosh|mac os|cpu os|cpu iphone os|android|windows phone|linux) )(\d+)(?:[-0-9_.])*/.exec(t);r&&(e.PlaformMajorVersion=r[1])},e.getVersionFromMatches=function(e){var t=-1,r="";return e&&(e[1]&&(r+=e[1],e[2]&&(r+="."+e[2])),""!==r&&(t=parseFloat(r),isNaN(t)&&(t=-1))),t},e.getVersionFromTrident=function(t,r){var n=new RegExp(r,"i").exec(t);return e.getVersionFromMatches(n)+4},e.fillDocumentElementBrowserTypeClassNames=function(t){for(var r="",n=t.concat(["WindowsPlatform","MacOSPlatform","MacOSMobilePlatform","AndroidMobilePlatform","WindowsPhonePlatform","WebKitFamily","WebKitTouchUI","MSTouchUI","TouchUI","AndroidDefaultBrowser"]),o=0;o<n.length;o++){var i=n[o];e[i]&&(r+="dx"+i+" ")}r+="dxBrowserVersion-"+e.MajorVersion,"undefined"!=typeof document&&document&&document.documentElement&&(""!==document.documentElement.className&&(r=" "+r),document.documentElement.className+=r,e.Info=r)},e.getUserAgent=function(){return e.hasNavigator()&&navigator.userAgent?navigator.userAgent.toLowerCase():""},e.UserAgent=e.getUserAgent(),e._foo=e.IdentUserAgent(e.UserAgent),e}(),r=Object.defineProperty({Browser:t},"__esModule",{value:!0}),n=function(){function e(){}return e.isAlpha=function(e){return e>="a"&&e<="z"||e>="A"&&e<="Z"},e.isDigit=function(e){return e>="0"&&e<="9"},e.stringHashCode=function(e){var t=0;if(0===e.length)return t;for(var r=e.length,n=0;n<r;n++)t=(t<<5)-t+e.charCodeAt(n),t|=0;return t},e.endsAt=function(e,t){var r=e.length-1,n=t.length-1,o=r-n;if(o<0)return!1;for(;r>=o;r--,n--)if(e[r]!==t[n])return!1;return!0},e.startsAt=function(e,t){return e.substr(0,t.length)===t},e.stringInLowerCase=function(e){return e.toLowerCase()===e},e.stringInUpperCase=function(e){return e.toUpperCase()===e},e.atLeastOneSymbolInUpperCase=function(t){for(var r=0,n=void 0;n=t[r];r++)if(e.stringInUpperCase(n)&&!e.stringInLowerCase(n))return!0;return!1},e.getSymbolFromEnd=function(e,t){return e[e.length-t]},e.trim=function(t,r){if(void 0===r)return e.trimInternal(t,!0,!0);var n=r.join("");return t.replace(new RegExp("(^["+n+"]*)|(["+n+"]*$)","g"),"")},e.trimStart=function(t,r){if(void 0===r)return e.trimInternal(t,!0,!1);var n=r.join("");return t.replace(new RegExp("^["+n+"]*","g"),"")},e.trimEnd=function(t,r){if(void 0===r)return e.trimInternal(t,!1,!0);var n=r.join("");return t.replace(new RegExp("["+n+"]*$","g"),"")},e.getDecimalSeparator=function(){return 1.1.toLocaleString().substr(1,1)},e.repeat=function(e,t){return new Array(t<=0?0:t+1).join(e)},e.isNullOrEmpty=function(e){return!e||!e.length},e.padLeft=function(t,r,n){return e.repeat(n,Math.max(0,r-t.length))+t},e.trimInternal=function(e,t,r){var n=e.length;if(!n)return e;if(n<764833){var o=e;return t&&(o=o.replace(/^\s+/,"")),r&&(o=o.replace(/\s+$/,"")),o}var i=0;if(r)for(;n>0&&/\s/.test(e[n-1]);)n--;if(t&&n>0)for(;i<n&&/\s/.test(e[i]);)i++;return e.substring(i,n)},e}();const o=Object.defineProperty({StringUtils:n},"__esModule",{value:!0});var i=Object.defineProperty({isDefined:function(e){return null!=e},boolToInt:function(e){return e?1:0},boolToString:function(e){return e?"1":"0"},isNumber:function(e){return"number"==typeof e},isString:function(e){return"string"==typeof e},isNonNullString:function(e){return!!e},isEven:function(e){return e%2!=0},isOdd:function(e){return e%2==0},numberToStringBin:function(e,t){return void 0===t&&(t=0),o.StringUtils.padLeft(e.toString(2),t,"0")},numberToStringHex:function(e,t){return void 0===t&&(t=0),o.StringUtils.padLeft(e.toString(16),t,"0")}},"__esModule",{value:!0});function u(e){return e&&e.__esModule&&Object.prototype.hasOwnProperty.call(e,"default")?e.default:e}function a(e){if(e.__esModule)return e;var t=Object.defineProperty({},"__esModule",{value:!0});return Object.keys(e).forEach((function(r){var n=Object.getOwnPropertyDescriptor(e,r);Object.defineProperty(t,r,n.get?n:{enumerable:!0,get:function(){return e[r]}})})),t}function l(e){var t={exports:{}};return e(t,t.exports),t.exports}const s=a(e);var f=function(e,t){this.minElement=e,this.maxElement=t},c=f,d=function(e){function t(){return null!==e&&e.apply(this,arguments)||this}return s.__extends(t,e),Object.defineProperty(t.prototype,"length",{get:function(){return this.maxElement-this.minElement},enumerable:!0,configurable:!0}),t}(f),m=function(e,t){this.minElement=e,this.minValue=t},v=function(e,t){this.maxElement=e,this.maxValue=t},h=function(e){function t(t,r,n,o){var i=e.call(this,t,n)||this;return i.minValue=r,i.maxValue=o,i}return s.__extends(t,e),t}(f),g=Object.defineProperty({MinMax:c,MinMaxNumber:d,ExtendedMin:m,ExtendedMax:v,ExtendedMinMax:h},"__esModule",{value:!0}),p=function(){function e(){}return e.number=function(e,t){return e-t},e.string=function(e,t){return e===t?0:e>t?1:-1},e.stringIgnoreCase=function(e,t){return(e=e.toLowerCase())===(t=t.toLowerCase())?0:e>t?1:-1},e}(),x=function(){function e(){}return e.simpleType=function(e,t){return e===t},e.object=function(e,t){return e&&t&&(e===t||e.equals(t))},e}(),y=Object.defineProperty({Comparers:p,Equals:x},"__esModule",{value:!0});const w=g,b=y;var M=function(){function e(){}return e.remove=function(e,t){var r=e.indexOf(t,0);r>=0&&e.splice(r,1)},e.removeBy=function(e,t){for(var r=e.length,n=0;n<r;n++)if(t(e[n],n))return e.splice(n,1)[0];return null},e.shallowCopy=function(e){return e.slice()},e.deepCopy=function(t){return e.map(t,(function(e){return e.clone()}))},e.initByValue=function(e,t){for(var r=[];e>0;e--)r.push(t);return r},e.initByCallback=function(e,t){for(var r=[],n=0;n<e;n++)r.push(t(n));return r},e.forEachOnInterval=function(e,t){for(var r=e.end,n=e.start;n<r;n++)t(n)},e.reverseForEachOnInterval=function(e,t){for(var r=e.start,n=e.end-1;n>=r;n--)t(n)},e.reducedMap=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=[],i=r;i<n;i++){var u=t(e[i],i);null!==u&&o.push(u)}return o},e.filter=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=[],i=r;i<n;i++){var u=e[i];t(u,i)&&o.push(u)}return o},e.map=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=[],i=r;i<n;i++)o.push(t(e[i],i));return o},e.indexBy=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=r;o<n;o++)if(t(e[o],o))return o;return-1},e.reverseIndexBy=function(e,t,r,n){void 0===r&&(r=e.length-1),void 0===n&&(n=0);for(var o=r;o>=n;o--)if(t(e[o],o))return o;return-1},e.elementBy=function(t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=t.length);var i=e.indexBy(t,r,n,o);return i<0?null:t[i]},e.reverseElementBy=function(t,r,n,o){void 0===n&&(n=t.length-1),void 0===o&&(o=0);var i=e.reverseIndexBy(t,r,n,o);return i<0?null:t[i]},e.last=function(e){return e[e.length-1]},e.setLast=function(e,t){return e[e.length-1]=t},e.incLast=function(e){return++e[e.length-1]},e.decLast=function(e){return--e[e.length-1]},e.equals=function(t,r){return t.length===r.length&&e.allOf2(t,r,(function(e,t){return e.equals(t)}))},e.equalsByReference=function(e,t){var r=e.length;if(r!==e.length)return!1;for(var n=0;n<r;n++)if(e[n]!==t[n])return!1;return!0},e.unique=function(t,r,n,o){void 0===n&&(n=r),void 0===o&&(o=function(){});var i=t.length;if(0===i)return[];var u=(t=t.sort(r))[0],a=e.reducedMap(t,(function(e){return 0!==n(u,e)?(u=e,e):(o(e),null)}),1,i);return a.unshift(t[0]),a},e.uniqueNumber=function(e){e=e.sort(b.Comparers.number);for(var t=Number.NaN,r=e.length-1;r>=0;r--)t===e[r]?e.splice(r,1):t=e[r];return e},e.forEach=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=r;o<n;o++)t(e[o],o)},e.forEach2=function(e,t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=e.length);for(var i=n;i<o;i++)r(e[i],t[i],i)},e.reverseForEach=function(e,t,r,n){void 0===r&&(r=e.length-1),void 0===n&&(n=0);for(var o=r;o>=n;o--)t(e[o],o)},e.reverseIndexOf=function(e,t,r,n){void 0===r&&(r=e.length-1),void 0===n&&(n=0);for(var o=r;o>=n;o--)if(e[o]===t)return o;return-1},e.accumulate=function(e,t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=e.length);for(var i=t,u=n;u<o;u++)i=r(i,e[u],u);return i},e.accumulateNumber=function(e,t,r,n,o){void 0===r&&(r=0),void 0===n&&(n=0),void 0===o&&(o=e.length);for(var i=r,u=n;u<o;u++)i+=t(e[u],u,i);return i},e.anyOf=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=r;o<n;o++)if(t(e[o],o))return!0;return!1},e.unsafeAnyOf=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=r;o<n;o++){var i=t(e[o],o);if(i)return i}return null},e.reverseAnyOf=function(e,t,r,n){void 0===r&&(r=e.length-1),void 0===n&&(n=0);for(var o=r;o>=n;o--)if(t(e[o],o))return!0;return!1},e.unsafeReverseAnyOf=function(e,t,r,n){void 0===r&&(r=e.length-1),void 0===n&&(n=0);for(var o=r;o>=n;o--){var i=t(e[o],o);if(i)return i}return null},e.anyOf2=function(e,t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=e.length);for(var i=n;i<o;i++)if(r(e[i],t[i],i))return!0;return!1},e.allOf=function(e,t,r,n){void 0===r&&(r=0),void 0===n&&(n=e.length);for(var o=r;o<n;o++)if(!t(e[o],o))return!1;return!0},e.allOf2=function(e,t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=e.length);for(var i=n;i<o;i++)if(!r(e[i],t[i],i))return!1;return!0},e.allOfOnInterval=function(e,t){for(var r=e.end,n=e.start;n<r;n++)if(!t(n))return!1;return!0},e.addListOnTail=function(e,t){for(var r=0,n=void 0;n=t[r];r++)e.push(n);return e},e.joinLists=function(t){for(var r=[],n=1;n<arguments.length;n++)r[n-1]=arguments[n];return e.accumulate(r,[],(function(r,n){return e.addListOnTail(r,t(n)),r}))},e.push=function(e,t){return e.push(t),e},e.countIf=function(t,r){return e.accumulateNumber(t,(function(e,t){return r(e,t)?1:0}))},e.clear=function(e){e.splice(0)},e.merge=function(e,t,r,n,o,i){if(void 0===o&&(o=0),void 0===i&&(i=e.length),e=e.slice(o,i),i-o<2)return e;for(var u=(e=e.sort(t))[o],a=[u],l=o+1;l<i;l++){var s=e[l];r(u,s)?n(u,s):a.push(u=s)}return a},e.min=function(t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=t.length);var i=e.minExtended(t,r,n,o);return i?i.minElement:null},e.max=function(t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=t.length);var i=e.maxExtended(t,r,n,o);return i?i.maxElement:null},e.minMax=function(t,r,n,o){void 0===n&&(n=0),void 0===o&&(o=t.length);var i=e.minMaxExtended(t,r,n,o);return i?new w.MinMax(i.minElement,i.maxElement):null},e.minExtended=function(e,t,r,n){if(void 0===r&&(r=0),void 0===n&&(n=e.length),0===e.length)return null;for(var o=e[r],i=t(o),u=r+1;u<n;u++){var a=e[u],l=t(a);l<i&&(i=l,o=a)}return new w.ExtendedMin(o,i)},e.maxExtended=function(e,t,r,n){if(void 0===r&&(r=0),void 0===n&&(n=e.length),0===e.length)return null;for(var o=e[r],i=t(o),u=r+1;u<n;u++){var a=e[u],l=t(a);l>i&&(i=l,o=a)}return new w.ExtendedMax(o,i)},e.minMaxExtended=function(e,t,r,n){if(void 0===r&&(r=0),void 0===n&&(n=e.length),0===e.length)return null;for(var o=e[r],i=o,u=t(o),a=u,l=r+1;l<n;l++){var s=e[l],f=t(s);f<u?(u=f,o=s):f>a&&(a=f,i=s)}return new w.ExtendedMinMax(o,u,i,a)},e.minByCmp=function(e,t,r,n){if(void 0===r&&(r=0),void 0===n&&(n=e.length),0===e.length)return null;for(var o=e[r],i=r+1;i<n;i++){var u=e[i];t(u,o)<0&&(o=u)}return o},e.maxByCmp=function(e,t,r,n){if(void 0===r&&(r=0),void 0===n&&(n=e.length),0===e.length)return null;for(var o=e[r],i=r+1;i<n;i++){var u=e[i];t(u,o)>0&&(o=u)}return o},e.minMaxByCmp=function(e,t,r,n){if(void 0===r&&(r=0),void 0===n&&(n=e.length),0===e.length)return null;for(var o=e[r],i=o,u=r+1;u<n;u++){var a=e[u],l=t(a,o);l>0?i=a:l<0&&(o=a)}return new w.MinMax(o,i)},e}();const E=Object.defineProperty({ListUtils:M},"__esModule",{value:!0});var T=function(){function e(){}return e.round=function(t,r){void 0===r&&(r=0);var n=e.powFactor[r];return Math.round(t*n)/n},e.numberCloseTo=function(e,t,r){return void 0===r&&(r=1e-5),Math.abs(e-t)<r},e.restrictValue=function(e,t,r){return r<t&&(r=t),e>r?r:e<t?t:e},e.getRandomInt=function(e,t){return Math.floor(Math.random()*(t-e+1))+e},e.generateGuid=function(){return"xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx".replace(/[xy]/g,(function(e){var t=16*Math.random()|0;return("x"===e?t:3&t|8).toString(16)}))},e.powFactor=E.ListUtils.initByCallback(20,(function(e){return Math.pow(10,e)})),e.somePrimes=[1009,1013,1019,1021,1031,1033,1039,1049,1051,1061,1063,1069,1087,1091,1093,1097,1103,1109,1117,1123,1129,1151,1153,1163,1171,1181,1187,1193,1201,1213,1217,1223,1229,1231,1237,1249,1259,1277,1279,1283,1289,1291,1297,1301,1303,1307,1319,1321,1327,1361,1367,1373,1381,1399,1409,1423,1427,1429,1433,1439,1447,1451,1453,1459,1471,1481,1483,1487,1489,1493,1499,1511,1523,1531,1543,1549,1553,1559,1567,1571,1579,1583,1597,1601,1607,1609,1613,1619,1621,1627,1637,1657,1663,1667,1669,1693,1697,1699,1709,1721,1723,1733,1741,1747,1753,1759,1777,1783,1787,1789,1801,1811,1823,1831,1847,1861,1867,1871,1873,1877,1879,1889,1901,1907,1913,1931,1933,1949,1951,1973,1979,1987,1993,1997,1999,2003],e}(),C=Object.defineProperty({MathUtils:T},"__esModule",{value:!0});const S=i,B=C;var P=function(){function e(){}return e.clearInnerHtml=function(e){for(;e.firstChild;)e.removeChild(e.firstChild)},e.setStylePosition=function(e,t){e.left=B.MathUtils.round(t.x,3)+"px",e.top=B.MathUtils.round(t.y,3)+"px"},e.setStyleSize=function(e,t){e.width=B.MathUtils.round(t.width,3)+"px",e.height=B.MathUtils.round(t.height,3)+"px"},e.setStyleSizeAndPosition=function(t,r){e.setStylePosition(t,r),e.setStyleSize(t,r)},e.hideNode=function(e){if(e){var t=e.parentNode;t&&t.removeChild(e)}},e.isHTMLElementNode=function(e){return e.nodeType===Node.ELEMENT_NODE},e.isTextNode=function(e){return e.nodeType===Node.TEXT_NODE},e.isElementNode=function(e){return e.nodeType===Node.ELEMENT_NODE},e.isHTMLTableRowElement=function(e){return"TR"===e.tagName},e.isItParent=function(e,t){if(!e||!t)return!1;for(;t;){if(t===e)return!0;if("BODY"===t.tagName)return!1;t=t.parentNode}return!1},e.getParentByTagName=function(e,t){for(t=t.toUpperCase();e;){if("BODY"===e.tagName)return null;if(e.tagName===t)return e;e=e.parentNode}return null},e.getDocumentScrollTop=function(){var t=r.Browser.IE&&"hidden"===e.getCurrentStyle(document.body).overflow&&document.body.scrollTop>0;return r.Browser.WebKitFamily||r.Browser.Edge||t?r.Browser.MacOSMobilePlatform?window.pageYOffset:r.Browser.WebKitFamily&&document.documentElement.scrollTop||document.body.scrollTop:document.documentElement.scrollTop},e.getDocumentScrollLeft=function(){var t=r.Browser.IE&&"hidden"===e.getCurrentStyle(document.body).overflow&&document.body.scrollLeft>0;return r.Browser.Edge||t?document.body?document.body.scrollLeft:document.documentElement.scrollLeft:r.Browser.WebKitFamily?document.documentElement.scrollLeft||document.body.scrollLeft:document.documentElement.scrollLeft},e.getCurrentStyle=function(e){if(e.currentStyle)return e.currentStyle;if(document.defaultView&&document.defaultView.getComputedStyle){var t=document.defaultView.getComputedStyle(e,null);if(!t&&r.Browser.Firefox&&window.frameElement){for(var n=[],o=window.frameElement;!(t=document.defaultView.getComputedStyle(e,null));)n.push([o,o.style.display]),o.style.setProperty("display","block","important"),o="BODY"===o.tagName?o.ownerDocument.defaultView.frameElement:o.parentNode;t=function(e){if("object"!=typeof e||!S.isDefined(e))return e;var t={};for(var r in e)t[r]=e[r];return t}(t);for(var i=void 0,u=0;i=n[u];u++)i[0].style.display=i[1]}return t}return window.getComputedStyle(e,null)},e.setFocus=function(e){function t(){try{e.focus(),r.Browser.IE&&document.activeElement!==e&&e.focus()}catch(e){}}r.Browser.MacOSMobilePlatform?t():setTimeout((function(){t()}),100)},e.hasClassName=function(e,t){try{var r=t.split(" "),n=e.classList;if(n){for(var o=r.length-1;o>=0;o--)if(!n.contains(r[o]))return!1}else{var i=e.getAttribute&&e.getAttribute("class");if(!i)return!1;var u=i.split(" ");for(o=r.length-1;o>=0;o--)if(u.indexOf(r[o])<0)return!1}return!0}catch(e){return!1}},e.addClassName=function(t,r){if(!e.hasClassName(t,r)){var n=t.getAttribute&&t.getAttribute("class");t.setAttribute("class",""===n?r:n+" "+r)}},e.removeClassName=function(e,t){var r=" "+(e.getAttribute&&e.getAttribute("class"))+" ",n=r.replace(" "+t+" "," ");r.length!==n.length&&e.setAttribute("class",o.StringUtils.trim(n))},e.toggleClassName=function(t,r,n){void 0===n?e.hasClassName(t,r)?e.removeClassName(t,r):e.addClassName(t,r):n?e.addClassName(t,r):e.removeClassName(t,r)},e.pxToInt=function(e){return I(e,parseInt)},e.pxToFloat=function(e){return I(e,parseFloat)},e.getAbsolutePositionY=function(t){function n(t){return Math.round(t.getBoundingClientRect().top+e.getDocumentScrollTop())}return t?r.Browser.IE?function(t){return r.Browser.IE&&null===t.parentNode?0:t.getBoundingClientRect().top+e.getDocumentScrollTop()}(t):r.Browser.Firefox&&r.Browser.Version>=3?n(t):r.Browser.Opera?function(t){var r=!0;t&&e.isHTMLTableRowElement(t)&&t.cells.length>0&&(t=t.cells[0]);for(var n=O(t,!1);null!=t;)n+=t.offsetTop,r||(n-=t.scrollTop),t=t.offsetParent,r=!1;return n+=document.body.scrollTop}(t):r.Browser.NetscapeFamily&&(!r.Browser.Firefox||r.Browser.Version<3)?function(t){for(var n=O(t,!1),o=!0;null!=t;){if(n+=t.offsetTop,o||null==t.offsetParent||(n-=t.scrollTop),!o&&r.Browser.Firefox){var i=e.getCurrentStyle(t);"DIV"===t.tagName&&"visible"!==i.overflow&&(n+=e.pxToInt(i.borderTopWidth))}o=!1,t=t.offsetParent}return n}(t):r.Browser.WebKitFamily||r.Browser.Edge?n(t):function(e){for(var t=0,r=!0;null!=e;)t+=e.offsetTop,r||null==e.offsetParent||(t-=e.scrollTop),r=!1,e=e.offsetParent;return t}(t):0},e.getAbsolutePositionX=function(t){function n(t){return Math.round(t.getBoundingClientRect().left+e.getDocumentScrollLeft())}return t?r.Browser.IE?function(t){return r.Browser.IE&&null===t.parentNode?0:t.getBoundingClientRect().left+e.getDocumentScrollLeft()}(t):r.Browser.Firefox&&r.Browser.Version>=3?n(t):r.Browser.Opera&&r.Browser.Version<=12?function(e){for(var t=!0,r=O(e,!0);null!=e;)r+=e.offsetLeft,t||(r-=e.scrollLeft),e=e.offsetParent,t=!1;return r+=document.body.scrollLeft}(t):r.Browser.NetscapeFamily&&(!r.Browser.Firefox||r.Browser.Version<3)?function(t){for(var n=O(t,!0),o=!0;null!=t;){if(n+=t.offsetLeft,o||null==t.offsetParent||(n-=t.scrollLeft),!o&&r.Browser.Firefox){var i=e.getCurrentStyle(t);"DIV"===t.tagName&&"visible"!==i.overflow&&(n+=e.pxToInt(i.borderLeftWidth))}o=!1,t=t.offsetParent}return n}(t):r.Browser.WebKitFamily||r.Browser.Edge?n(t):function(e){for(var t=0,r=!0;null!=e;)t+=e.offsetLeft,r||null==e.offsetParent||(t-=e.scrollLeft),r=!1,e=e.offsetParent;return t}(t):0},e.isInteractiveControl=function(e){return["A","INPUT","SELECT","OPTION","TEXTAREA","BUTTON","IFRAME"].indexOf(e.tagName)>-1},e.getClearClientHeight=function(t){return t.offsetHeight-(e.getTopBottomPaddings(t)+e.getVerticalBordersWidth(t))},e.getTopBottomPaddings=function(t,r){var n=r||e.getCurrentStyle(t);return e.pxToInt(n.paddingTop)+e.pxToInt(n.paddingBottom)},e.getVerticalBordersWidth=function(t,n){S.isDefined(n)||(n=r.Browser.IE&&9!==r.Browser.MajorVersion&&window.getComputedStyle?window.getComputedStyle(t):e.getCurrentStyle(t));var o=0;return"none"!==n.borderTopStyle&&(o+=e.pxToFloat(n.borderTopWidth)),"none"!==n.borderBottomStyle&&(o+=e.pxToFloat(n.borderBottomWidth)),o},e.getNodes=function(e,t){for(var r=e.all||e.getElementsByTagName("*"),n=[],o=0;o<r.length;o++){var i=r[o];t(i)&&n.push(i)}return n},e.getChildNodes=function(e,t){for(var r=e.childNodes,n=[],o=0;o<r.length;o++){var i=r[o];t(i)&&n.push(i)}return n},e.getNodesByClassName=function(t,r){if(t.querySelectorAll){var n=t.querySelectorAll("."+r),o=[];return n.forEach((function(e){return o.push(e)})),o}return e.getNodes(t,(function(t){return e.hasClassName(t,r)}))},e.getChildNodesByClassName=function(t,r){return t.querySelectorAll?function(e,t){for(var r=[],n=0;n<e.length;n++){var o=e[n];t(o)&&r.push(o)}return r}(t.querySelectorAll("."+r),(function(e){return e.parentNode===t})):e.getChildNodes(t,(function(t){return!!e.isElementNode(t)&&(S.isNonNullString(t.className)&&e.hasClassName(t,t.className))}))},e.getVerticalScrollBarWidth=function(){if(void 0===e.verticalScrollBarWidth){var t=document.createElement("DIV");t.style.cssText="position: absolute; top: 0px; left: 0px; visibility: hidden; width: 200px; height: 150px; overflow: hidden; box-sizing: content-box",document.body.appendChild(t);var r=document.createElement("P");t.appendChild(r),r.style.cssText="width: 100%; height: 200px;";var n=r.offsetWidth;t.style.overflow="scroll";var o=r.offsetWidth;n===o&&(o=t.clientWidth),e.verticalScrollBarWidth=n-o,document.body.removeChild(t)}return e.verticalScrollBarWidth},e.getHorizontalBordersWidth=function(t,n){S.isDefined(n)||(n=r.Browser.IE&&window.getComputedStyle?window.getComputedStyle(t):e.getCurrentStyle(t));var o=0;return"none"!==n.borderLeftStyle&&(o+=e.pxToFloat(n.borderLeftWidth)),"none"!==n.borderRightStyle&&(o+=e.pxToFloat(n.borderRightWidth)),o},e.getFontFamiliesFromCssString=function(e){return e.split(",").map((function(e){return o.StringUtils.trim(e.replace(/'|"/gi,""))}))},e.getInnerText=function(t){if(r.Browser.Safari&&r.Browser.MajorVersion<=5){null===e.html2PlainTextFilter&&((e.html2PlainTextFilter=document.createElement("DIV")).style.width="0",e.html2PlainTextFilter.style.height="0",e.html2PlainTextFilter.style.overflow="visible",e.html2PlainTextFilter.style.display="none",document.body.appendChild(e.html2PlainTextFilter));var n=e.html2PlainTextFilter;n.innerHTML=t.innerHTML,n.style.display="";var o=n.innerText;return n.style.display="none",o}return r.Browser.NetscapeFamily||r.Browser.WebKitFamily||r.Browser.IE&&r.Browser.Version>=9||r.Browser.Edge?t.textContent:t.innerText},e.html2PlainTextFilter=null,e.verticalScrollBarWidth=void 0,e}(),N=P;function I(e,t){var r=0;if(S.isDefined(e)&&""!==e)try{var n=e.indexOf("px");n>-1&&(r=t(e.substr(0,n)))}catch(e){}return r}function O(e,t){for(var r=0,n=!0;null!=e&&"BODY"!==e.tagName;){var o=P.getCurrentStyle(e);if("absolute"===o.position)break;n||"DIV"!==e.tagName||""!==o.position&&"static"!==o.position||(r-=t?e.scrollLeft:e.scrollTop),e=e.parentNode,n=!1}return r}var A=Object.defineProperty({DomUtils:N},"__esModule",{value:!0});export{t as B,N as D,S as a,r as b,l as c,A as d,u as g,o as s};
