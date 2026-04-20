[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/Byjocgi8)
[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/jsGMBNPT)
[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-2e0aaae1b6195c2367325f4f02e2d04e9abb55f0b24a779b69b11b9e10269abc.svg)](https://classroom.github.com/online_ide?assignment_repo_id=19156791&assignment_repo_type=AssignmentRepo)
# QuoteMachine-ExerciceGit

Une petite application console collaborative en C# pour générer et gérer des citations inspirantes — conçue pour pratiquer le **GitHub Flow** en équipe.

[![Build and Test QuoteMachine](https://github.com/oliviertremblay/QuoteMachine-ExerciceGit/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/oliviertremblay/QuoteMachine-ExerciceGit/actions/workflows/dotnet-desktop.yml)

---

## 🎯 Objectif

Développer une application C# console par itérations, en respectant le GitHub Flow :
- Création d'une branche par fonctionnalité
- Pull Request (PR) pour chaque ajout
- Votre PR ne peut pas être crée si les tests ne passent pas.
- Revue de code par au moins une personne avant le merge

---

## 🎮 But du jeu

- Travailler en équipe pour compléter un maximum de fonctionnalités.
- Écrire le code requis pour faire passer les tests reliés à votre fonctionnalité (aucun test doit être commenté à la fin).
- Respecter les bonnes pratiques Git et faire approuver vos PRs.
- Livrer un projet propre, bien structuré... et qui compile évidemment !

---

## 🧱 Structure du projet

  ```bash
QuoteMachine/
├── Program.cs           # Point d'entrée de l'application
├── Quote.cs             # Classe représentant une citation
└── QuoteManager.cs      # Classe qui gère les citations (à compléter)
```
---

## 🛠 Fonctionnalités à développer

Chaque fonctionnalité doit être développée dans **une branche distincte**, puis intégrée via une **pull request**.

### ➕ Fonctionnalités proposées :

| Branche                        | Fonctionnalité                                         |
|-------------------------------|--------------------------------------------------------|
| `feature/random-quote`        | Méthode pour retourner une citation au hasard         |
| `feature/add-quote`           | Ajouter une citation manuellement depuis la console   |
| `feature/menu`                | Créer un menu interactif qui expose les fonctionnalités dans `Program.cs`            |
| `feature/save-to-file`        | Sauvegarder les citations dans un fichier csv       |
| `feature/load-from-file`      | (Optionnel) Charger les citations à partir d’un fichier csv |

---

## ✅ Étapes recommandées

1. **Cloner le projet** et créer une nouvelle branche :
```bash
   git checkout -b feature/nom-de-votre-fonctionnalité
```
3. **Coder votre fonctionnalité localement** et vérifier que les tests unitaires reliés à votre fonctionnalité passent.

4. **Pousser votre branche sur GitHub** :
```bash
   git push origin feature/nom-de-votre-fonctionnalité
```
6. **Créer une Pull Request** sur GitHub

7. **Demander une revue** à un collègue

8. **Une fois approuvée**, merger la PR dans `main`

---

## 👩‍💻 Bonnes pratiques

- Chaque membre devrait :
  - créer au moins une branche
  - approuver au moins une PR d’un autre
- Les commits doivent être clairs et descriptifs
- Testez vos fonctionnalités avant de soumettre une PR

---

## 💡 Exemple de citation

```text
"La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre." - Albert Einstein
```

---

## 🎓 Projet éducatif

Ce projet est conçu comme un exercice d’apprentissage collaboratif du **versionnage Git** et du **travail d’équipe sur GitHub**.

Bonne collaboration à tous et toutes ! 🚀
