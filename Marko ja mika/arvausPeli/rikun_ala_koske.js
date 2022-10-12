let arvattavaNro = Math.floor(Math.random()*10)+1;
let kerrat = 0;
let arvatutNrot = [];
function arvaa(arvo){


  if(arvo.value == arvattavaNro){  //Tarkistetaan onko klikattu nappi yhtäsuuri kuin arvattava numero
    arvatutNrot.push(arvo.value); // lisätään arvattu numero "arvatutNrot" arrayhin

    kerrat++ // lisätään 1 klikkaus "kerrat" muuttujaan


document.getElementById("m3").innerHTML = "Oikein"; //jos klikatun napin arvo on yhtäsuuri
                                                    // kuin arvattava numero, OIKEIN
document.getElementById("reload").disabled = false;  // sekä reload button disabled=false
                                              //reload button siis päivittää selaimen...
}
else if(arvo.value >= arvattavaNro){    //Tarkistetaan onko klikattu nappi suurempi kuin arvattava numero
  arvatutNrot.push(arvo.value); // lisätään arvattu numero "arvatutNrot" arrayhin
  kerrat++ // lisätään 1 klikkaus "kerrat" muuttujaan

document.getElementById("m3").innerHTML = "Liian suuri!"; 
}
else if(arvo.value <= arvattavaNro){
  arvatutNrot.push(arvo.value);
  kerrat++
document.getElementById("m3").innerHTML = "Liian pieni!";
}

if (kerrat==3) {

document.getElementById("m3").innerHTML = "Better luck next time......";

alert("Hävisit!!");

document.getElementById("reload").disabled = false;




}
console.log(kerrat);
  m1.innerHTML = "Arvausten lukumäärä: " + kerrat;
  m2.innerHTML = "Arvatut numerot: " + arvatutNrot;

}
function refresh(update){

  location.reload();
}
