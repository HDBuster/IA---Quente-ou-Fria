# Exercício para — 6.7.: Redes Neurais Artificiais

Neste projeto UNITY, o usuário escolherá duas opções para caracterizar a cor de fundo: Quente ou Fria.  
Após nove entradas, a Rede Neural tentará descobrir se a cor é Quente ou Fria, baseado nas respostas do usuário.

a) Como a Rede Neural seleciona 'a cor mais fácil de ler'?
R: A partir das escolhas dos botões realizadas pelo usuário.
A Rede Neural escolhe a melhor opção, baseada nas entradas do usuário, a partir da décima cor aleatória.

b) Como funciona o passo prévio de treinamento e passo posterior de uso do modelo treinado?
A cada entrada, a Rede Neural registra a cor atual e a opção selecionada.
O código detecta a opção selecionada, e não a cor do texto do botão.
A Rede Neural espera por nove entradas como treinamento.
A partir da décima entrada (quando o código verifica que já houve o treinamento e já obteve nove entradas), a Rede escolhe a melhor opção, baseada nas entradas do usuário.


Alunos:  
Breno de Souza Vieira  
Samuel Figueirêdo
