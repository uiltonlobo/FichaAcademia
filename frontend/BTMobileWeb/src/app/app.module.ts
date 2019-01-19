import { ClienteService } from './cliente.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { Ficha_Listar } from './ficha/listar/listar.component';
import { Ficha_Editar } from './ficha/editar/editar.component';
import { Ficha_AlterarCarga } from './ficha/alterar-carga/alterar-carga.component';
import { Cliente_Listar } from './cliente/listar/listar.component';
import { Cliente_Detalhe } from './cliente/detalhe/detalhe.component';
import { Ficha_SerieFicha } from './ficha/serie-ficha/serie-ficha.component';
import { Ficha_ExercicioSerie } from './ficha/exercicio-serie/exercicio-serie.component';
import { Exercicio_Listar } from './exercicio/listar/listar.component';

import { FichaService } from './ficha.service';

import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { Exercicio_Detalhe } from './exercicio/detalhe/detalhe.component';


const appRoutes: Routes = [
  //{ path: 'ficha', component: ListarComponent }
  { path: '', component: Ficha_Listar },
  { path: 'ficha/:id', component: Ficha_Editar},
  { path: 'alterarCarga', component: Ficha_AlterarCarga},
  { path: 'cliente', component: Cliente_Listar},
  { path: 'cliente/:id', component: Cliente_Detalhe},
  { path: 'exercicio', component: Exercicio_Listar},
  { path: 'exercicio/:id', component: Exercicio_Detalhe},
  { path: 'serieFicha/:fichaId', component: Ficha_SerieFicha},
  { path: 'exercicioSerie', component: Ficha_ExercicioSerie}
]

@NgModule({
  declarations: [
    AppComponent,
    Ficha_Listar,
    Ficha_Editar,
    Ficha_AlterarCarga,
    Cliente_Listar,
    Cliente_Detalhe,
    Ficha_SerieFicha,
    Ficha_ExercicioSerie,
    Exercicio_Listar,
    Exercicio_Detalhe
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    FichaService,
    ClienteService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
