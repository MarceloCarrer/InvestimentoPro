import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-transacoes',
  templateUrl: './transacoes.component.html',
  styleUrls: ['./transacoes.component.scss']
})
export class TransacoesComponent implements OnInit {

  public transacoes: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getTransacoes();
  }

  public getTransacoes(): void {
    this.http.get('https://localhost:5001/api/transacoes/').subscribe(
      response => this.transacoes = response,
      error => console.log(error)
    );
  }
}
