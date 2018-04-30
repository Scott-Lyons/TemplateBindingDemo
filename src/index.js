"use strict";
exports.__esModule = true;
var underscore_demo_1 = require("./underscore-demo");
var args = {
    name: "Mr Harry Potter",
    Address_Line_1: "The cupboard under the stairs",
    Address_Line_2: "4 Privet Drive",
    Town_City: "Little Whinging",
    County: "Surrey",
    Body: "Hello, your latest bill is now ready to view online."
};
var start = new Date().getMilliseconds();
for (var i = 0; i < 1000; i++) {
    var underscoreDemo = new underscore_demo_1["default"]();
    underscoreDemo.Run(args);
}
var end = new Date().getMilliseconds();
console.log("Time taken " + (end - start) + " milliseconds");
//# sourceMappingURL=index.js.map