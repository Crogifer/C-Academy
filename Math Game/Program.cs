using Math_Game;

var menu = new Menu();
string name = Helpers.GetName();
var date = DateTime.UtcNow;

menu.RunMenu(name, date);