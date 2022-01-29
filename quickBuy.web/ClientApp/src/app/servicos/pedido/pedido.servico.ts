import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Pedido } from "../../modelo/pedido";
import { Observable } from "rxjs"import { HttpHeaders } from "../../../../node_modules/@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class PedidoServico {
  public _baseUrl: string;

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type','application/json');
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  public efetivarCompra(pedido: Pedido): Observable<number> {
    return this.http.post<number>(this._baseUrl + "api/pedido", JSON.stringify(pedido), {headers: this.headers});
  }

}
