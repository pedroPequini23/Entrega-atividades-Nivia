itealgoritmo "Exercicio Posto"
// Função :
// Autor : Pedro Pequini  e Renan Mitsuru
// Data : 16/03/2023
// Seção de Declarações 
var
  result1,result2,litros:real
  tipo:caracter
inicio
escreva("Digite a quantidade de litros obtidos:")
leia(litros)
escreva("Digite o combustível escolhido, A para álcool, e G para gasolina:")
leia(tipo)
se (tipo="A") entao
   se (litros <= 20)entao
      result1:= (litros * 4.30)
      result2:= result1-(result1*3/100)
      escreva (result2)
   senao
        result1:= (litros * 4.30)
        result2:= result1-(result1*5/100)
        escreva (result2)
   fimse
   
   senao
        se (tipo="G") entao
           se(litros <=20) entao
                     result1:=(litros * 5.50)
                     result2:= result1 - (result1 *4/100)
                     escreva (result2)
           senao
                result1:=(litros * 5.50)
                result2:=result1 -(result1*6/100)
                escreva (result2)
           fimse
        fimse
   fimse
fimalgoritmo
