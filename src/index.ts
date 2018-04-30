import UnderscoreDemo from './underscore-demo';
import DemoRunner from './demo-runner';

const args = {
    name: "Mr Harry Potter",
    Address_Line_1: "The cupboard under the stairs",
    Address_Line_2: "4 Privet Drive",
    Town_City: "Little Whinging",
    County: "Surrey",
    Body: "Hello, your latest bill is now ready to view online."
};

let start = new Date().getMilliseconds();

let demoRunner = new DemoRunner();

demoRunner.Run(new UnderscoreDemo(), args);

let end = new Date().getMilliseconds();

console.log("Time taken " + (end - start) + " milliseconds");