import {readFileSync} from "fs";
import * as underscore from "underscore";
import IDemo from "./IDemo";

class UnderscoreDemo implements IDemo {
    public Run(args:any): void { 
        const source = readFileSync(`${__dirname}\\..\\..\\underscore-template.html`, "UTF-8");
                       
        const tpl = underscore.template(source);
        console.log(tpl(args));        
    }
}

export default UnderscoreDemo;