// esitellään muuttujat pelikentän kokoon
var constants = new (function() {
    var rows = 0;
    var columns = 0;
    do {
      rows = prompt('Anna rivien parillinen lukumäärä');
    }
    while(rows%2 !=0 || rows>4);
    do{
      columns = prompt('Anna sarakkeiden parillinen lukumäärä');
    }
    while(columns%2 != 0  || columns>8);

    var numMatches = (rows * columns) / 2;
    this.getRows = function() { return rows; };
    this.getColumns = function() { return columns; };
    this.getNumMatches = function() { return numMatches; };
})();

// Globaalit muuttujat
var	currentSessionOpen = false;
var	previousCard = null;
var numPairs = 0;
var click = 0;


function klik() {
  click++;
  document.getElementById('klikkaa').innerHTML = Math.floor(click/2);
}

// Luodaan pelikenttä
function createDeck() {
	var rows = constants.getRows();
	var cols = constants.getColumns();
	var key = createRandom();
	var deck = {};
	deck.rows = [];

	// Luodaan rivit
	for(var i = 0; i < rows; i++) {
		var row = {};
		row.cards = [];

		// Luodaan kortit riviin
		for (var j = 0; j < cols; j++) {
			var card = {};
			card.isFaceUp = false;
			card.item = key.pop();
			row.cards.push(card);
		}
		deck.rows.push(row);
	}
	return deck;
}

// used to remove something form an array by index
function removeByIndex(arr, index) {
    arr.splice(index, 1);
}

function insertByIndex(arr, index, item) {
	arr.splice(index, 0, item);
}

// creates a random array of items that contain matches
// for example: [1, 5, 6, 5, 1, 6]
function createRandom() {
	var matches = constants.getNumMatches();
	var pool = [];
	var answers = [];
	var letters = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'
					, 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R'
					, 'S', 'T', 'U', 'W', 'X', 'Y', 'Z'];

	var hiragana = ['あ', 'い', 'う', 'え', 'お', 'か', 'が', 'き'
					, 'ぎ', 'く', 'ぐ', 'け', 'げ', 'こ', 'ご', 'さ'
					, 'ざ', 'し', 'じ', 'す', 'ず', 'せ', 'ぜ', 'そ'
					, 'ぞ', 'た', 'だ', 'ち', 'ぢ', 'つ', 'づ', 'て'
					, 'で', 'と', 'ど', 'な', 'に', 'ぬ', 'ね', 'の'
					, 'は', 'ば', 'ぱ', 'ひ', 'び', 'ぴ', 'ふ', 'ぶ'
					, 'ぷ', 'へ', 'べ', 'ぺ', 'ほ', 'ぼ', 'ぽ', 'ま'
					, 'み', 'む', 'め', 'も', 'や', 'ゆ', 'よ', 'ら'
					, 'り', 'る', 'れ', 'ろ', 'わ', 'を', 'ん'];

  var emojis = ['😀', '😁', '😄', '🫣', '💑', '👨‍❤️‍👨', '💏', '👨‍❤️‍💋‍👨', '🕵🏻‍♀️', '🕵🏻', '🕵🏻‍♂️', '🧑🏻‍🎓', '👨🏻‍🎓', '👩🏻‍🎓', '🧑🏻‍🦳', '👨🏻‍🦳', '🧙🏻‍♀️','🧙🏻', '🧛🏻', '🧛🏻‍♂️'];

	// Valitaan mitä kenttä halutaan näyttää
	var items = emojis;

	// luodaan satunnaset numerot
	for (var i = 0; i < matches * 2; i++) {
		pool.push(i); // satunnais numerot
	}

	// luodaan taulukko satunnaistista kohteista
	for (var n = 0; n < matches; n++) {
		// luodaan satunnainen kirjain ja poistetaan se alkuperäisestä taulukosta

		var randLetter = Math.floor((Math.random() * items.length));
		var letter = items[randLetter];
		removeByIndex(items, randLetter);
		// luodaan jokaiselle itemille satunnainen paikka taulukosta
		var randPool = Math.floor((Math.random() * pool.length));

		// poistaa paikkamerkin vastauksista ja lisää kirjaimen satunnaisen kohtaan

		insertByIndex(answers, pool[randPool], letter);

		// poistaa satunnaisen numeron pool
		removeByIndex(pool, randPool);

		// toistaa tämän prosessin toista sijoitusta varten
		randPool = Math.floor((Math.random() * pool.length));
		insertByIndex(answers, pool[randPool], letter);

		// poistaa satunnaisen numeron poolista
		removeByIndex(pool, randPool);
	}
	return answers;
}

var app = angular.module('cards', ['ngAnimate']);

app.controller("CardController", function($scope, $timeout) {
	$scope.deck = createDeck();
	$scope.isGuarding = true;
	$scope.inGame = false;

	$scope.check = function(card) {
		if (currentSessionOpen && previousCard != card && previousCard.item == card.item && !card.isFaceUp) {
			card.isFaceUp = true;
			previousCard = null;
			currentSessionOpen = false;
			numPairs++;
		} else if(currentSessionOpen && previousCard != card && previousCard.item != card.item && !card.isFaceUp) {
			$scope.isGuarding = true;
			card.isFaceUp = true;
			currentSessionOpen = false;
			$timeout(function() {
				previousCard.isFaceUp = card.isFaceUp = false;
				previousCard = null;
				$scope.isGuarding = $scope.timeLimit ? false : true;
			}, 1000);
		} else {
			card.isFaceUp = true;
			currentSessionOpen = true;
			previousCard = card;
		}
    klik();
		if (numPairs == constants.getNumMatches()) {
			$scope.stopTimer();
		}
	} //tarkastuksen lopetus

	// ajastin
	$scope.timeLimit = 300000;
	$scope.isCritical = false;

	var timer = null;

	// käynnistää ajastimen kun käyttäjä aloittaa pelin
	$scope.start = function(){

		// pelin aloitus nappi
		$scope.deck = createDeck();
		// asettaa peliajaksi 5 minuuttia ja vapauttaa kortit pelaamista varten
		$scope.timeLimit = 300000;
		$scope.isGuarding = false;
		$scope.inGame = true;

		($scope.startTimer =function() {
			$scope.timeLimit -= 1000;
			$scope.isCritical = $scope.timeLimit <= 10000 ? true : false;

			timer = $timeout($scope.startTimer, 1000);
			if ($scope.timeLimit === 0) {
				$scope.stopTimer();
				$scope.isGuarding = true;
			}
		})();
	}
	// ajastimen keskeytys 
	$scope.stopTimer = function() {
	  $timeout.cancel(timer);
	  $scope.inGame = false;
	  previousCard = null;
	  currentSessionOpen = false;
	  numPairs = 0;
	}
});
