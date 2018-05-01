"use strict";
exports.__esModule = true;
var DemoRunner = (function () {
    function DemoRunner() {
    }
    DemoRunner.prototype.Run = function (demo, args) {
        for (var i = 0; i < 1000; i++) {
            demo.Run(args);
        }
    };
    return DemoRunner;
}());
exports["default"] = DemoRunner;
//# sourceMappingURL=demo-runner.js.map