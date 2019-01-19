import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44362/api';
  
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  public listar() {
    return this.http.get(this.accessPointUrl + "/cliente", { headers: this.headers });
  }

  public obterPorId(id: number) {
    return this.http.get(this.accessPointUrl + "/cliente/" + id, { headers: this.headers });
  }

  public incluir(id: number, nome: string, success) {
    return this.http
      .post(this.accessPointUrl + "/cliente", {id: id, nome: nome}, { headers: this.headers })
      .subscribe(
        data => { success(); },
        error => { console.log("Error", error); }
      );
  }

  public alterar(id: number, nome: string, success) {
    return this.http
      .put(this.accessPointUrl + "/cliente/" + id, {id: id, nome: nome}, { headers: this.headers })
      .subscribe(
        data => { success(); },
        error => { console.log("Rrror", error); }
      );
  }

  public excluir(id: number) {
    return this.http
      .delete(this.accessPointUrl + "/cliente/" + id, { headers: this.headers });
  }

}
