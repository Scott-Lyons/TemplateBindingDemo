"use strict";
exports.__esModule = true;
var underscore_demo_1 = require("./Demos/underscore-demo");
var demo_runner_1 = require("./demo-runner");
var args = {
    name: "Mr Harry Potter",
    Address_Line_1: "The cupboard under the stairs",
    Address_Line_2: "4 Privet Drive",
    Town_City: "Little Whinging",
    County: "Surrey",
    Body: "Hello, your latest bill is now ready to view online."
};
var start = new Date().getMilliseconds();
var demoRunner = new demo_runner_1["default"]();
demoRunner.Run(new underscore_demo_1["default"](), args);
var end = new Date().getMilliseconds();
console.log("Time taken " + (end - start) + " milliseconds");
//# sourceMappingURL=index.js.map