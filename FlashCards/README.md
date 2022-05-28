A primitive and open source flashcard displayer written in C# (winforms).

The application has the following features currently (2022.05.28):
  - creating a **flashcard deck** from a file that needs a
    specific format:
                    - one line contains one flashcard
                    - the front side of the card is separated from the back side with a special character                    
  - navigating between flashcards with a **Next**, **Previous** and **Reset** buttons
  - **Shuffle** the cards in a deck
  - **Flip** the card to its back or its front

  Technical part:

  The program uses an interface called `ICard`. This interface has the following functions:
  `public string GetFront()` and `public string GetBack()`. These functions return each sides of the card.
  You may create your own class implementing the `ICard` interface, it will be compatible with the current state of the program.
