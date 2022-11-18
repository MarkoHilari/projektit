/* Haetaan lomakkeelta painike ja laitetaan sille clickauksen 'kuuntelu' */
  let enterButton = document.getElementById("painike");
  enterButton.addEventListener("click",addListClick); // PerÃ¤sssÃ¤ funktio, jota kutsutaan

/* Haetaan lomakkeelta syÃ¶ttÃ¶kenttÃ¤ ja laitetaan sille enterin 'kuuntelu' */
  let input = document.getElementById("syotto");
  input.addEventListener("keypress", addEnter); // PerÃ¤ssÃ¤ funktio, jota kutsutaan

/* Haetaan lomakkeelta jÃ¤rjestÃ¤mÃ¤tÃ¶n lista, johon tehtÃ¤vÃ¤t syÃ¶tetÃ¤Ã¤n */
  let ul = document.querySelector("ul");

/* Luodaan funktio, joka palauttaa syÃ¶tetyn merkkijonon pituuden */
function inputLength()
{
	return input.value.length;
}

/* Varsinainen lisÃ¤ysfunktio */
function addList()
{
	let li = document.createElement("li"); // luo "li" elementin
  // Tarkistetaan, ettÃ¤ on syÃ¶tetty jotain
  if(input.value != '')
  {
    li.appendChild(document.createTextNode(input.value)); //lisÃ¤tÃ¤Ã¤n li-elementtiin tekstin, joka on laatikossa
  	ul.appendChild(li); //lisÃ¤Ã¤ li-elementin ul-elementtiin
  	input.value = ""; // TyhjentÃ¤Ã¤ syÃ¶ttÃ¶kentÃ¤n
  }

	// Aloitetaan tehdyn tehtÃ¤vÃ¤n vÃ¤rjÃ¤ys
	// koska se on funktiossa, se tekee sen vain lisÃ¤ttyihin tehtÃ¤viin
	function doneTask() {
		li.classList.toggle("done");
	}
  // Kutsutaan yllÃ¤olevaa funktiota
	li.addEventListener("click",doneTask);
	//Tehdyn tehtÃ¤vÃ¤n vÃ¤rjÃ¤ys loppuu


	// Aloitetaan poistopainikkeen lisÃ¤ys
	let poisto = document.createElement("button"); // luodaan painike-elementti
	poisto.appendChild(document.createTextNode("X")); // LisÃ¤tÃ¤Ã¤n siihen X-kirjain
	li.appendChild(poisto); // LisÃ¤tÃ¤Ã¤n se kaikkiin li-elementteihin
	poisto.addEventListener("click", removeMissionImpossible);
	// Poistopainikkeen lisÃ¤ys loppuu


	//LisÃ¤tÃ¤Ã¤n varsinainen poistofunktio (DISPLAY: NONE)
	function removeMissionImpossible()
  {
		li.classList.add("delete")
	}
}// PÃ¤Ã¤funktio pÃ¤Ã¤ttyy


function addListClick()
{
	if (inputLength() > 0) { //tarkistaa, ettÃ¤ on syÃ¶tetty jotain
		addList(); // Kutsuu 'pÃ¤Ã¤funktiota'
	}
}

function addEnter(event)
{
	if (inputLength() > 0 && event.which ===13) { //Tarkistetaan, ettÃ¤ Enter on painettu
		//nro 13 on Enterin avainkoodi, voidaan kirjoittaa myÃ¶s event.keyCode === 13
		addList(); // Kutsuu 'pÃ¤Ã¤funktiota'
	}
}
