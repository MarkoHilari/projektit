// insert() functio lisää btn arvon textview kohtaan

function insert(num)
{
document.form1.textview.value = document.form1.textview.value + num;
}
// Käytä equal() funktiota palauttamaan tulos pohjautuen syötettyihin arvoihin.

function equal()
{
var exp = document.form1.textview.value;
if(exp)
{
document.form1.textview.value = eval(exp)
}
}
/*  tehdään backspace() funktio jolla voidaan poistaa numeroita textview:istä*/

function backspace()
{
var exp = document.form1.textview.value;
document.form1.textview.value = exp.substring(0, exp.length - 1);    /*poistetaan elementti = kokonaispituudesta -1 */
}
