import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { stringify } from '@angular/core/src/util';

@Injectable()
export class FichaService {
  
  private headers: HttpHeaders;
  //private accessPointUrl: string = 'https://localhost:44362/api';
  private accessPointUrl: string = 'https://localhost:5001/api';
  
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  public getProfessores() {
    return this.http.get(this.accessPointUrl + "/professor", { headers: this.headers });
  }

  public getClientes() {
    return this.http.get(this.accessPointUrl + "/cliente", { headers: this.headers });
  }

  public getExercicios() {
    return this.http.get(this.accessPointUrl + "/exercicio", { headers: this.headers });
  }

  public getFichas(professorId: number, clienteId: number) {
    return this.http.get(this.accessPointUrl + "/ficha?professorId=" + professorId + "&clienteId=" + clienteId, { headers: this.headers});
  }

  public getFicha(id: number) {
    return this.http.get(this.accessPointUrl + "/ficha/" + id, {headers: this.headers});
  }
  
  public alterarCarga(fichaId: number, clienteId: number, exercicioSerieId: number, novaCarga: number, ok: any) {
    
    let parametros = {
      FichaId: fichaId,
      ClienteId: clienteId,
      ExercicioSerieId: exercicioSerieId,
      ValorCarga: novaCarga
    }

    let url:string = this.accessPointUrl + "/exercicioserie/" + fichaId;

    return this.http
      .put(url, parametros, {headers: this.headers})
      .subscribe(
          data => { 
            console.log("PUT Request is successful ", data);
            ok();
          },
          error => { console.log("Rrror", error); }
    )  ;
  }

  public adicionarSerieFicha(fichaId: number, rotuloSerie: any, ok: any) {
    let parametros = {
      FichaId: fichaId,
      RotuloSerie: rotuloSerie
    }

    let url:string = this.accessPointUrl + "/serieFicha";

    return this.http
      .post(url, parametros, {headers: this.headers})
      .subscribe(
          data => { 
            console.log("POST Request is successful ", data); 

            if (ok) ok();
          },
          error => { 
            console.log("Error", error.error.message); 
            alert(error.error.message);
          }
    );
  }
  
  public adicionarExercicioSerie(serieFichaId: number, exercicioId: number, repeticao: string, carga: number, ok: any) {
    let parametros = {
      SerieFichaId: serieFichaId,
      ExercicioId: exercicioId,
      Repeticao: repeticao,
      Carga: carga      
    }

    let url:string = this.accessPointUrl + "/ExercicioSerie";

    return this.http
      .post(url, parametros, {headers: this.headers})
      .subscribe(
          data => { 
            console.log("POST Request is successful ", data); 
            if (ok) ok();
          },
          error => { 
            console.log("Error", error.error.message); 
            alert(error.error.message);
          }
    );
  }
}