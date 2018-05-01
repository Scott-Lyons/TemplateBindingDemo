import IDemo from "./Demos/IDemo";

export default class DemoRunner {
    constructor() {}

    Run(demo: IDemo, args: any) : void {
        for(let i = 0; i < 1000; i++) {    
            demo.Run(args);
        }
    }
}