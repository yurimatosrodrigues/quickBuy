import { Produto } from "../../modelo/produto";

export class LojaCarrinhoCompras {
  public produtos: Produto[] = [];

  public adicionar(produto: Produto) {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");

    this.produtos = JSON.parse(produtoLocalStorage);
    
    if (this.produtos.length > 0) {      
      if (!this.produtos.find(p => p.id == produto.id)) {
        this.produtos.push(produto);
      }      
    }
    else {      
      this.produtos.push(produto);      
    }    
    localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));    
  }

  public obterProdutos(): Produto[]{
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
    if (produtoLocalStorage)
      return JSON.parse(produtoLocalStorage);

  }

  public removerProduto(produto: Produto) {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
    if (produtoLocalStorage) {
      this.produtos = JSON.parse(produtoLocalStorage);
      this.produtos = this.produtos.filter(p => p.id != produto.id);
      localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
    }   
  }

  public atualizar(produtos: Produto[]) {
    localStorage.setItem("produtoLocalStorage", JSON.stringify(produtos));
  }
}
