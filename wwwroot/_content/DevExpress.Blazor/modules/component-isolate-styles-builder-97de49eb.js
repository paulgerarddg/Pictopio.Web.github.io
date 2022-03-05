import{s as e}from"./dom-b082d2b1.js";var r=function(){function r(){}return r.getAlpha=function(e){return e>>24&255},r.getRed=function(e){return e>>16&255},r.getGreen=function(e){return e>>8&255},r.getBlue=function(e){return 255&e},r.redPartToString=function(e){var t=r.getRed(e).toString(16);return t.length>1?t:"0"+t},r.greenPartToString=function(e){var t=r.getGreen(e).toString(16);return t.length>1?t:"0"+t},r.bluePartToString=function(e){var t=r.getBlue(e).toString(16);return t.length>1?t:"0"+t},r.fromArgbNumber=function(e,r,t,a){return e<<24|r<<16|t<<8|a},r.fromRgbaString=function(e,r){void 0===r&&(r=255);var t=e.replace(/ +/g,"").match(/(rgba?)|(\d+(\.\d+)?%?)|(\.\d+)/g);if(t&&t.length>3){for(var a=[],o=1,f=void 0;f=t[o];o++){var n=-1!==f.indexOf("%")?Math.round(2.55*parseFloat(f)):parseInt(f);if(n<0||n>255)return null;a.push(n)}if(0===e.indexOf("rgba")){if(isNaN(a[3])||a[3]<0||a[3]>1)return null;a[3]<=1&&(a[3]=Math.round(255*a[3]))}else if(a[3])return null;return(255&a[0])<<16|(255&a[1])<<8|255&a[2]|(255&(a.length>3?a[3]:r))<<24}return null},r.fromHashString=function(t,a){return void 0===a&&(a=255),r.isHashColorString(t)?("#"===t.charAt(0)&&(t=t.substr(1)),3===t.length&&(t=e.StringUtils.repeat(t.charAt(0),2)+e.StringUtils.repeat(t.charAt(1),2)+e.StringUtils.repeat(t.charAt(2),2)),parseInt(t,16)|a<<24):null},r.fromColorName=function(e,t){void 0===t&&(t=255);var a=r.colorNames[e.toLowerCase()];return a?r.fromHashString(a,t):null},r.fromString=function(e,t){void 0===t&&(t=255);var a=r.fromRgbaString(e,t);if(null!==a)return a;var o=r.fromHashString(e,t);return null!==o?o:r.fromColorName(e,t)},r.colorToHash=function(e){return"#"+r.redPartToString(e)+r.greenPartToString(e)+r.bluePartToString(e)},r.stringToHash=function(e){var r=this.fromString(e);return null!==r?this.colorToHash(r):null},r.isHashColorString=function(e){return/^#?([0-9a-f]{6})$/i.test(e)||/^#?([0-9a-f]{3})$/i.test(e)},r.isKnownColorName=function(e){return!!r.colorNames[e.toLowerCase()]},r.isGray=function(e){var t=r.getRed(e);return t===r.getGreen(e)&&t===r.getBlue(e)},r.DARK_COLOR=-16777216,r.LIGHT_COLOR=-1,r.colorNames={aliceblue:"#f0f8ff",antiquewhite:"#faebd7",aqua:"#00ffff",aquamarine:"#7fffd4",azure:"#f0ffff",beige:"#f5f5dc",bisque:"#ffe4c4",black:"#000000",blanchedalmond:"#ffebcd",blue:"#0000ff",blueviolet:"#8a2be2",brown:"#a52a2a",burlywood:"#deb887",cadetblue:"#5f9ea0",chartreuse:"#7fff00",chocolate:"#d2691e",coral:"#ff7f50",cornflowerblue:"#6495ed",cornsilk:"#fff8dc",crimson:"#dc143c",cyan:"#00ffff",darkblue:"#00008b",darkcyan:"#008b8b",darkgoldenrod:"#b8860b",darkgray:"#a9a9a9",darkgreen:"#006400",darkkhaki:"#bdb76b",darkmagenta:"#8b008b",darkolivegreen:"#556b2f",darkorange:"#ff8c00",darkorchid:"#9932cc",darkred:"#8b0000",darksalmon:"#e9967a",darkseagreen:"#8fbc8f",darkslateblue:"#483d8b",darkslategray:"#2f4f4f",darkturquoise:"#00ced1",darkviolet:"#9400d3",deeppink:"#ff1493",deepskyblue:"#00bfff",dimgray:"#696969",dodgerblue:"#1e90ff",feldspar:"#d19275",firebrick:"#b22222",floralwhite:"#fffaf0",forestgreen:"#228b22",fuchsia:"#ff00ff",gainsboro:"#dcdcdc",ghostwhite:"#f8f8ff",gold:"#ffd700",goldenrod:"#daa520",gray:"#808080",green:"#00ff00",greenyellow:"#adff2f",honeydew:"#f0fff0",hotpink:"#ff69b4",indianred:"#cd5c5c",indigo:"#4b0082",ivory:"#fffff0",khaki:"#f0e68c",lavender:"#e6e6fa",lavenderblush:"#fff0f5",lawngreen:"#7cfc00",lemonchiffon:"#fffacd",lightblue:"#add8e6",lightcoral:"#f08080",lightcyan:"#e0ffff",lightgoldenrodyellow:"#fafad2",lightgray:"#d3d3d3",lightgreen:"#90ee90",lightpink:"#ffb6c1",lightsalmon:"#ffa07a",lightseagreen:"#20b2aa",lightskyblue:"#87cefa",lightslateblue:"#8470ff",lightslategray:"#778899",lightsteelblue:"#b0c4de",lightyellow:"#ffffe0",lime:"#00ff00",limegreen:"#32cd32",linen:"#faf0e6",magenta:"#ff00ff",maroon:"#800000",mediumaquamarine:"#66cdaa",mediumblue:"#0000cd",mediumorchid:"#ba55d3",mediumpurple:"#9370d8",mediumseagreen:"#3cb371",mediumslateblue:"#7b68ee",mediumspringgreen:"#00fa9a",mediumturquoise:"#48d1cc",mediumvioletred:"#c71585",midnightblue:"#191970",mintcream:"#f5fffa",mistyrose:"#ffe4e1",moccasin:"#ffe4b5",navajowhite:"#ffdead",navy:"#000080",oldlace:"#fdf5e6",olive:"#808000",olivedrab:"#6b8e23",orange:"#ffa500",orangered:"#ff4500",orchid:"#da70d6",palegoldenrod:"#eee8aa",palegreen:"#98fb98",paleturquoise:"#afeeee",palevioletred:"#d87093",papayawhip:"#ffefd5",peachpuff:"#ffdab9",peru:"#cd853f",pink:"#ffc0cb",plum:"#dda0dd",powderblue:"#b0e0e6",purple:"#800080",red:"#ff0000",rosybrown:"#bc8f8f",royalblue:"#4169e1",saddlebrown:"#8b4513",salmon:"#fa8072",sandybrown:"#f4a460",seagreen:"#2e8b57",seashell:"#fff5ee",sienna:"#a0522d",silver:"#c0c0c0",skyblue:"#87ceeb",slateblue:"#6a5acd",slategray:"#708090",snow:"#fffafa",springgreen:"#00ff7f",steelblue:"#4682b4",tan:"#d2b48c",teal:"#008080",thistle:"#d8bfd8",tomato:"#ff6347",turquoise:"#40e0d0",violet:"#ee82ee",violetred:"#d02090",wheat:"#f5deb3",white:"#ffffff",whitesmoke:"#f5f5f5",yellow:"#ffff00",yellowgreen:"#9acd32",windowtext:"#000000"},r}();Object.defineProperty({ColorUtils:r},"__esModule",{value:!0});class t{constructor(){this._lightColor=-1,this._darkColor=-1,this._primaryColor=-1}get lightColor(){return this._lightColor}get darkColor(){return this._darkColor}get primaryColor(){return this._primaryColor}buildStyleSheet(e){let r=0;const t=setInterval((()=>{this._lightColor=this.getColorByVarName("--light","--bs-light"),this._darkColor=this.getColorByVarName("--dark","--bs-dark"),this._primaryColor=this.getColorByVarName("--primary","--bs-primary"),-1!==this._darkColor||-1!==this._lightColor?(e.innerHTML=this.buildStyleSheetCore(),clearInterval(t)):r>100&&clearInterval(t),r++}),100)}getColorByVarName(e,r){const t=`var(${e}${void 0!==r?", var("+r+")":""})`;return this.getElementValue((e=>e.style.backgroundColor=t),(e=>this.getBackgroundColorByElement(e)))}getBackgroundColorByElement(e){if(!e)return-1;const t=getComputedStyle(e).backgroundColor;return r.fromRgbaString(t)||-1}getElementValue(e,r,t="div"){const a=document.createElement(t);document.body.appendChild(a),e(a);const o=r(a);return document.body.removeChild(a),o}useBlackMixColor(e){return this.lightColor>e}static getMixedColorVarDeclaration(e,t,a,o){const f=(1-o)*r.getRed(t)+o*r.getRed(a),n=(1-o)*r.getGreen(t)+o*r.getGreen(a),l=(1-o)*r.getBlue(t)+o*r.getBlue(a);return`${e}: rgb(${Math.round(f)}, ${Math.round(n)}, ${Math.round(l)});`}}export{t as C};