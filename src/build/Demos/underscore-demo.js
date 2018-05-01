"use strict";
exports.__esModule = true;
var fs_1 = require("fs");
var underscore = require("underscore");
var UnderscoreDemo = (function () {
    function UnderscoreDemo() {
    }
    UnderscoreDemo.prototype.Run = function (args) {
        var source = fs_1.readFileSync(__dirname + "\\..\\..\\underscore-template.html", "UTF-8");
        var tpl = underscore.template(source);
        console.log(tpl(args));
    };
    return UnderscoreDemo;
}());
exports["default"] = UnderscoreDemo;
//# sourceMappingURL=underscore-demo.js.map