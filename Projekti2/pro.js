var arvattava = Math.floor(Math.random()*10)+1;
var kerrat = 0;

window.onload= function ponnahdusIkkuna()
{

alert(arvattava);

}

//arpa funktion parametriin haetaan value ->= buttonvalue html:ssä
function arvaa(arpa)
{
  //joka kerta kun funktio ajetaan, lisätään "kerrat" muuttujan arvoon +1
  kerrat++;
  var arvaus = arpa.value;// <-- tähän siis parametrinä htmlstä button value

// jos kokeilet 3 kertaa
  if(kerrat <= 3)
  {
// jos arvaat vähemmän kun arvattava = (mathrandometc....)
    if(arvaus < arvattava)
    {
      alert('Valitsit liian pienen numeron');


      var x = '';
      for(var luvut = 1; luvut < arvaus; luvut++)
      {
        x = document.getElementsByName('' + luvut+ '');

        console.log(x);
        x.style.nayta = "none";
      }
    }
    else if(arvaus > arvattava)
    {
      alert('Valitsit liian suuren numeron');
    }
    else if (arvaus == arvattava){
      alert('Oikein, kÃ¤ytit ' + kerrat + ' kertaa');
    }
    else {
      alert('KÃ¤ytit kaikki kertasi');
    }
  }

}
