
/* Luodaan enter toiminto, funktiolla kutusutaan toimintoa*/
  let enterButton = document.getElementById("painike");
  enterButton.addEventListener("click",addListClick);

/* Haetaan syöttökentästä tiedot, funktiolla kutsutaan */
  let input = document.getElementById("syotto");
  input.addEventListener("keypress", addEnter);
/* Luodaan järjestämättömän listan alku  */
  let ul = document.querySelector("ul");

/* Luodaan tarkatus, että syöttökentässä on jotain tietoa */
function inputLength()
{
	return input.value.length;
}

/* Tehdään funktio joka lisää li elementin */
function addList()
{
	let li = document.createElement("li");
  // Tarkistus, että on syötetty jotain tietoa
  if(input.value != '')
  {
    li.appendChild(document.createTextNode(input.value)); //lisää tiedot jotka on syötetty
  	ul.appendChild(li); //lisää li:n ul
  	input.value = ""; // resetoi syöttökentän
  }

	/* muutetaan tehtävät tehdyksi*/
	function doneTask() {
		li.classList.toggle("done");
	}
  // funktion kutsu
	li.addEventListener("click",doneTask);
	//Funktion loppu


	// Poistopainike "X"
	let poisto = document.createElement("button"); // luodaan painike-muuttuja
	poisto.appendChild(document.createTextNode("X")); // Poistoelementtin X kirjain
	li.appendChild(poisto); // X nappi poistettaviin tehtäviin li
	poisto.addEventListener("click", removeMissionImpossible);


	//Poistifunktio
	function removeMissionImpossible()
  {
		li.classList.add("delete")
	}
}

// Lisätään listaan klikkauksella funktio
function addListClick()
{
	if (inputLength() > 0) { //Tarkistus että on syötetty jotain tietoa
		addList(); // Kutsuu addList funktio, joka on yllä mainittu
	}
}

function addEnter(event)
{
	if (inputLength() > 0 && event.which === 13) { //Enterin painallus
		//nro 13 on Enterin avainkoodi
		addList(); // Kutsuu addList funktio, joka on yllä mainittu
	}
}
