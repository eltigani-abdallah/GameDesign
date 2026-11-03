
Game design document template (outline)

# Overview

## Pitch

Le pouvoir necessite des sacrifices. dans cette monde, mangez, ou faites vous mangez, ce sont vos seuls choix. laquelle vous choisirez?

## Public cible

10 - 18 ans d'age, joueur des jeux sociales (jeux de societé, mario party etc.)

## Platform

Navigateur web

# Core gameplay

## Boucle principale

Jouer -> gagner de l'argent -> perdre -> acheter des cosmetics/personnages -> jouer

## Controls

Clavier ou souris

## Conditions de gagne/perte

Gagne: aucun. jeu de survie, on joue jusqu'a ce qu'on perd
Perte: avoir sa taille reduite jusquá 0 par un de moyens suivants:
- se faire mangé par un autre joueur
- un des pieges presents sur le map


## Modes de jeu

- Classique: Agar.io sans modifications. ici les personnages n'ont pas leur pouvoirs et il y a un nombre minimum des pieges
- Noveau: les personnages auront des pouvoirs selon le personnage utilisé, les attaques, pieges, techniques de defenses, tout joue dans cette aréne chaotique
- Solo: Jouez contre les bots qui prennent la place des joueurs. les pouvoir sont autorisées ici donc c'est le moment parfait pour s'entrainer. peut se faire en Noveau et Classique
- Ranked: mêmes regles de Nouveau, sauf qu'il y a un ranking mondial qui joue. serez vous les grands masters de Pagario?

# Systems (regles)

Vue orthographique d'haut, le terrain de jeu est en 2D ou on se deplace dans les 4 directions.
## Movement

deux choix de controle: 
- Clavier: 
	- WASD (ZQSD) ou fléches: se déplacer
	- ESPACE: se diviser
	- C: se disperser en petits boules qui peuvent être mangé soit par nous soit par des autres joueurs
	- V: pouvoir speciale selon le personnage
- Souris
	- DIRECTION DE SOURIS: se deplacer dans le direction de souris
	- CLICK GAUCHE: pouvoir speciale selon le personnage
	- CLICK DROITE: se diviser
	- CLICK CENTRE: se disperser


## Combat

Mode classique: les joueurs rentre en "combat" lors de contact, le joueur le plus grand mange le joueur le plus petit, par contre les grands joueurs sont plus lent que les petits joueurs

Modes Ranked, Solo, Nouveau: mémes regles de mode classique, sauf l'ajout de pouvoir des personnages. tous les combats vont dependre des personnages participants.

## Progression

systeme de collection de personnages plutôt que progression classique. 

## Economy

aucun echange monetaire entre les joueurs. l'argent gagné depend de nombre de joueurs tué/mangé

## AI

disponible uniquement en mode Solo, mouvement qui ressemble aux vrais joueurs.

## Difficulté et notes de balance

Le difficulté de jeu en tout mode sauf Classique dépend largement sur les personnages obtenu, un révu est obligatoire lors de l'ajout de certains personnages afin d'eviter le powercreep ou que un personnage devient le meta

# Content

## Levels / maps

Cosmetiques a acheter.

## Personnages / classes

- Default: personnage par défaut. pas de pouvoirs speciales
- Dasher: peut effectuer un boost court afin d'esquiver/attaquer plus rapidement. plus grand taille = plus longue cooldown
- Poisson: quand il se disperse il laisse de poison au lieu de la norriture. le poison peut lui affecter lui meme
- Bomb: quand il se fait mangé, le joueur qui l'a mangé explose. si je meurs tu meurs toi aussi.

plus de personnages au fuir et a mesure


## Ennemis

autres joueurs ou des IA en mode solo
# UX and UI


## Player journey (flow)

```mermaid
flowchart TB

menu[Menu]

settings[settings]

cust[customization]

play[play]

subgraph MainMenu
menu --> settings
menu --> cust
menu --> play
end

cust --> customize
play --> ModeSelect
settings --> SettingsMenu
subgraph customize

character

map

skin

end

subgraph ModeSelect
Classic
Noveau
Solo{solo}
Ranked{Ranked}

Solo --> ClassicS
Solo --> NoveauS

Ranked --> ClassicR
Ranked --> NoveauR

end

subgraph SettingsMenu

Language
Controls
Sound
Account
end

```


# Marketing et monetization

## Business model

Systeme gacha: le devise utilisé pour acquerir des personnages, cartes, et cosmetiques sont achetée par des vrais argents, ou gagné plus lentement sans payer 

c'est possible d'acheter les boosters (multiplicateurs) qui font un sort que chaque tour de jeu peut donner plus de devises.

courtes publicités entre les respawn.