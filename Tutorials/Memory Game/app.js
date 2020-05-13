document.addEventListener("DOMContentLoaded", () => {
  const cardArray = [
    {
      name: "sword",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Sword.png"
    },
    {
      name: "sword",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Sword.png"
    },
    {
      name: "hamster",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Hamster.png"
    },
    {
      name: "hamster",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Hamster.png"
    },
    {
      name: "chicken",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Chicken.png"
    },
    {
      name: "chicken",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Chicken.png"
    },
    {
      name: "turtle",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Turtle.png"
    },
    {
      name: "turtle",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Turtle.png"
    },
    {
      name: "pick",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Mining%20Pick.png"
    },
    {
      name: "pick",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Mining%20Pick.png"
    },
    {
      name: "mushroom",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Mushroom.png"
    },
    {
      name: "mushroom",
      img:
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Mushroom.png"
    },
    {
      name: "blue",
      img: ""
    },
    {
      name: "",
      img: ""
    }
  ];

  cardArray.sort(() => 0.5 - Math.random());

  const grid = document.querySelector(".grid");
  const resultDisplay = document.querySelector("#result");
  let cardsChosen = [];
  let cardsChosenId = [];
  const cardsWon = [];

  function createBoard() {
    for (let i = 0; i < cardArray.length; i++) {
      let card = document.createElement("img");
      card.setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Token.png"
      );
      card.setAttribute("data-id", i);
      card.addEventListener("click", flipCard);
      grid.appendChild(card);
    }
  }
  function checkForMatch() {
    let cards = document.querySelectorAll("img");
    const optionOneId = cardsChosenId[0];
    const optionTwoId = cardsChosenId[1];
    if (optionOneId == optionTwoId) {
      cards[optionOneId].setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Token.png"
      );
      cards[optionTwoId].setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Token.png"
      );
    } else if (cardsChosen[0] === cardsChosen[1]) {
      alert("You found a match!");
      cards[optionOneId].setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Done.png"
      );
      cards[optionTwoId].setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Done.png"
      );
      cards[optionOneId].removeEventListener("click", flipCard);
      cards[optionTwoId].removeEventListener("click", flipCard);
      cardsWon.push(cardsChosen);
    } else {
      cards[optionOneId].setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Token.png"
      );
      cards[optionTwoId].setAttribute(
        "src",
        "https://raw.githubusercontent.com/Zukilprime/Tutorials/master/Tutorials/Memory%20Game/Images/Token.png"
      );
      alert("Sorry, try again!");
    }
    cardsChosen = [];
    cardsChosenId = [];
    resultDisplay.textContent = cardsWon.length;
    if (cardsWon.length === cardArray.length / 2) {
      resultDisplay.textContent = " Congratulations! You found them all!";
    }
  }

  function flipCard() {
    let cardId = this.getAttribute("data-id");
    cardsChosen.push(cardArray[cardId].name);
    cardsChosenId.push(cardId);
    this.setAttribute("src", cardArray[cardId].img);
    if (cardsChosen.length === 2) {
      setTimeout(checkForMatch, 500);
    }
  }

  createBoard();
});
