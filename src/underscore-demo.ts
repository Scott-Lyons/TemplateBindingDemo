import {readFileSync} from "fs";
import * as underscore from "underscore";




class UnderscoreDemo {
    public Run(args:any): void { 
        const source = readFileSync(`${__dirname}\\template.html`, "UTF-8");
                       
        const tpl = underscore.template(source);
        console.log(tpl(args));        
    }
}

export default UnderscoreDemo;