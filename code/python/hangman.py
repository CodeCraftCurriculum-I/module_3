from threading import Timer
import random, sys
import  graphics 
import ansi as  ANSI

HANGMAN_UI = graphics.HANGMAN_UI
WORD_LIST = ["car", "cat", "dog", "elephant", "fish", "giraffe", "horse", "monkey", "panda", "sheep", "tiger", "zebra", "ant","bee","marmelade","computer","dax","sjøbanan"]
MAX_ATEMPTS = len(HANGMAN_UI) #len er hvordan man finner lengden av variabler som lister og tekst med python
atempts = 0

word = random.choice(WORD_LIST)
wordLength = len(word)
wordArray = list(word) #Python har en split funksjon, men den splitter ikke til enkelt bokstaver, men vi kan konvertere direkte til en liste 
wordDisplay = ['_'] * wordLength

guesses = []
isPlaing = True


def write(text) :
    sys.stdout.write(text)

def exitGame() :
    write(ANSI.CLEAR_SCREEN)
    write(ANSI.CURSOR_HOME)
    sys.exit(0)


write(ANSI.CLEAR_SCREEN)

while isPlaing :

    write(ANSI.CLEAR_SCREEN)
    write(ANSI.moveCursorTo(0,0))
    write("Lets play Hangman!\n")
    write(f'{ANSI.moveCursorTo(4,20)} Word: {" ".join(wordDisplay)}\n')
    write(f'{ANSI.moveCursorTo(6,20)} Guesses: {" ".join(guesses)}\n')
    write(ANSI.CURSOR_HOME)
    write(f'{HANGMAN_UI[atempts]}\n')

    write("Your guess: ")
    guess = input()
    guesses.append(guess)

    if guess in wordArray :
        # Denne er ikke like frem å forstå, men vi trennger en index for å kunne sette verdier 
        # i wordDisplay listen, derfor lager vi to varabler index (posisjon i listen som git av enumerate)
        # og letter som er det faktiske tegnet vi skal sjekke mot.
        for index, letter in  enumerate(wordArray) :
            if letter == guess :
                wordDisplay[index] = f'{ANSI.GREEN}{letter}{ANSI.RESET}'
    else :
        atempts += 1

    if atempts == MAX_ATEMPTS :
        isPlaing = False

write(f'{ANSI.RED}GAME OVER\n{ANSI.RESET}')



timer = Timer(3.0, exitGame)
timer.start()
