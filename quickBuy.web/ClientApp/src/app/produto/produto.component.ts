import { Component } from "@angular/core"

@Component({
    selector: "app-produto", //nome da tag HTML onde o componente vai ser renderizado
    template: "" // estrutura do HTML 
})
export class ProdutoComponent {    //export disponibiliza a classe para utilização no módulo. Torna "public"
    public nome: string = 'teste';
    public liberadoParaVenda: boolean;

    //camelCase para variáveis, atributos e funções.
    public obterNome(): string {
        return this.nome;
    }

}
