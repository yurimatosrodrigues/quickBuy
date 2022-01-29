import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ProdutoComponent } from './produto/produto.component';
import { LoginComponent } from './usuario/login/login.component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { UsuarioServico } from './servicos/usuario/usuario.servico';
import { CadastroUsuarioComponent } from './usuario/cadastro/cadastro.usuario.component';
import { ProdutoServico } from './servicos/produto/produto.servico';
import { PesquisaProdutoComponent } from './produto/pesquisa.produto/pesquisa.produto.component';
import { LojaPesquisaComponent } from './loja/pesquisa/loja.pesquisa.component';
import { TruncateModule } from 'ng2-truncate';
import { LojaProdutoComponent } from './loja/produto/loja.produto.component';
import { LojaEfetivarComponent } from './loja/efetivar/loja.efetivar.component';
import { PedidoServico } from './servicos/pedido/pedido.servico';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,    
    ProdutoComponent,
    LoginComponent,
    CadastroUsuarioComponent,
    PesquisaProdutoComponent,
    LojaPesquisaComponent,
    LojaProdutoComponent,
    LojaEfetivarComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    TruncateModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },      
      { path: 'produto', component: ProdutoComponent, canActivate: [GuardaRotas]},
      { path: 'entrar', component: LoginComponent },
      { path: 'novo-usuario', component: CadastroUsuarioComponent },
      { path: 'pesquisar-produto', component: PesquisaProdutoComponent, canActivate: [GuardaRotas]},
      { path: 'loja-produto', component: LojaProdutoComponent },
      { path: 'loja-efetivar', component: LojaEfetivarComponent, canActivate: [GuardaRotas] }
], { relativeLinkResolution: 'legacy' })
  ],
  providers: [UsuarioServico, ProdutoServico, PedidoServico],
  bootstrap: [AppComponent]
})
export class AppModule { }
