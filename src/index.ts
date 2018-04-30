import UnderscoreDemo from './underscore-demo';



const args = {
    name: "Mr Harry Potter",
    Address_Line_1: "The cupboard under the stairs",
    Address_Line_2: "4 Privet Drive",
    Town_City: "Little Whinging",
    County: "Surrey",
    Body: "Hello, your latest bill is now ready to view online."
};

let start = new Date().getMilliseconds();

for(let i = 0; i < 1000; i++) {    
    let underscoreDemo = new UnderscoreDemo();
    underscoreDemo.Run(args);
}

let end = new Date().getMilliseconds();

console.log("Time taken " + (end - start) + " milliseconds");