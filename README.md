# implicit-explicit-operators
Quando e como usar conversões com implicit e explicit operators em C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra quando e como usar conversões com implicit e explicit operators em C#.

**Implicit:** Deve ser usado quando a conversão entre tipos é segura e não há perda de dados. Isso é comum quando a conversão é amplamente considerada segura e não há risco de perder informações ou quando a conversão é intuitiva e natural.

**Explicit:** Deve ser usado quando a conversão entre tipos pode causar perda de dados ou quando a conversão é menos óbvia e pode ser potencialmente perigosa se feita implicitamente. Também é útil quando a conversão pode ser feita, mas pode não ser a operação mais comum ou desejável.

O uso de implicit ou explicit deve seguir o princípio da clareza e da segurança. Se a conversão entre tipos não apresenta perigo de perda de informações e é uma operação comum e esperada, pode ser adequado usar um operador implicit. Já se a conversão é mais complexa, pode levar a perdas de dados ou é uma operação menos comum, o operador explicit é mais apropriado para garantir que a conversão seja realizada de forma consciente e explícita pelo programador.

<div align="center">
    <img src="https://github.com/jfs-dev/implicit-explicit-operators/assets/54154628/518a2b6c-26ab-4562-ae9c-15e3f2e6ae51"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators/

## Licença
GPL-3.0 license
