let painallus = document.getElementById('painike');
painallus.addEventListener("click", lisaaLista);

let syotto = document.getElementById('syotto');
syotto.addEventListener("keypress", lisaaListaanE);

let ul = document.querySelector("ul");

function inputLength()
{
  return syotto.value.length;
}
function luoLista()
{
   let li = document.createElement("li");
   if(syotto.value != '')
   {
     li.appendChild(document.createTextNode(syotto.value));
     ul.appendChild(li);
     syotto.value = "";
   }
   function ulostulo()
   {
     li.classList.toggle("valmis");
   }
   li.addEventListener("click", valmis);
   let poisto = document.createElement("button");
   poisto.appendChild(document.createTextNode("xxx"));
   li.appendChild(poisto);
   poisto.addEventListener("click", vahennaTaakkaa);
   function vahennaTaakkaa()
   {
     li.classList.add("delete") //muuta tätä jos mahdollista
   }
 }
   function lisaaLista()
   {
     if (inputLength() > 0){luoLista();
     }
   }
   function lisaaListaanE(event)
   {
     if (inputLength() > 0 && event.which === 13)
     {
       lisaaListaanE();
     }
   }
