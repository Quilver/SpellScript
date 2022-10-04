# Spellscript

A c# interpreter for our general purpose programming language with a gui in unity

## Getting Started

### Clone github repository and open in Unity **(2021.3.11f1 LTS)**
If you don't already have Unity 2021.3 LTS then you can download it: 

Open Unity Hub -> Installs -> Install Editor -> 2021.3.11f1 LTS  (It should be the top recommended version)

Once you've clicked install it'll prompt you to add additional dependencies (e.g. android build support) ignore that and just click 'Continue'

Once you have Unity installed  you can run the command below from a shell window (e.g. cmd or git bash) to clone the repository.
If you don't have git installed you can follow this guide: https://git-scm.com/book/en/v2/Getting-Started-Installing-Git

```sh
git clone git@github.com:UEA-advanced-programmers/SpellScript.git
```

If you opt to use Github Desktop instead you can do so:
Go to the repository page, click 'Code' -> 'Open with GitHub desktop' -> clone

Once you've cloned the rpeository, you should be able to open the project in Unity.
Open Unity Hub -> Open -> SpellScript/

## Testing

Currently there is a simple unit test stored within the /Tests/ folder (This test should always fail). You can run this by opening the 'Unity Test Runner':
Click Window -> General -> Test Runner. From there you can Run all or run a selection of tests. 
Alternatively if you're using rider as your IDE you can run the unity tests from within:
Click Tests -> Run all tests from solution
