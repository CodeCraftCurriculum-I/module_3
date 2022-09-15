import * as readlinePromises from 'node:readline/promises';
import { HANGMAN_UI } from "./graphics.mjs";
import {ANSI} from "./ansi.mjs";

const rl = readlinePromises.createInterface({input: process.stdin,output: process.stdout});
const WORD_LIST = ["car", "cat", "dog", "elephant", "fish", "giraffe", "horse", "monkey", "panda", "sheep", "tiger", "zebra", "ant","bee","marmelade","computer"];

let atempts = 0;
const MAX_ATEMPTS = HANGMAN_UI.length-1;
const word = WORD_LIST[Math.floor(Math.random() * WORD_LIST.length)];
const wordLength = word.length;
const wordArray = word.split("");
const wordDisplay = new Array(wordLength).fill("_");

const guesses = [];
let isPlaing = true;

write(ANSI.CLEAR_SCREEN)

while(isPlaing){
    
    write(ANSI.CLEAR_SCREEN)
    write(ANSI.CURSOR_HOME)
    write("Lets play Hangman!\n");
    write(`${ANSI.moveCursorTo(4,20)} Word: ${wordDisplay.join(" ")}\n`);
    write(`${ANSI.moveCursorTo(6,20)} Guesses: ${guesses.join(" ")}\n`);
    write(ANSI.CURSOR_HOME)
    write(`${HANGMAN_UI[atempts]}\n`);
    
    const guess = await rl.question("Your guess: ");
    guesses.push(guess);
    if(wordArray.includes(guess)){
        wordArray.forEach((letter, index) => {
            if(letter === guess){
                wordDisplay[index] = `${ANSI.COLOR.GREEN}${letter}${ANSI.RESET}`;
            }
        });
    } else{
        atempts++;
    }

    if(atempts === MAX_ATEMPTS){
        isPlaing = false;
    }

}

write(`${ANSI.COLOR.RED}GAME OVER\n${ANSI.RESET}`)

setTimeout(() => {
    write(ANSI.CLEAR_SCREEN);
    write(ANSI.CURSOR_HOME);
    process.exit(0);
}, 3000);


function write(text) {
    process.stdout.write(text);
}