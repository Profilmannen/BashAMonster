Weapon ak47 = new Weapon();
Weapon knife = new Weapon();

ak47.Name = "Ak-47";
ak47.damage = 100;

knife.Name = "Knife";


karaktär Dino = new karaktär(){
    Name = "Dino",

    hitpoints = 1000
};



Dino.hitpoints -= ak47.damage;

