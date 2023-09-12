import { Component, OnInit,HostListener } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { MatDialog, MatDialogRef,MAT_DIALOG_DATA } from '@angular/material/dialog';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { Platform } from '@angular/cdk/platform';
import { RegistroRequest } from 'src/app/dtos/RegistroDTO';
import { Registro } from 'src/app/Services/Registro.Service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.scss']
})
export class RegistroComponent implements OnInit {
  form: FormGroup;
  loading: boolean;
    constructor(public platform:Platform,public dialog: MatDialog, private fb: FormBuilder, private router: Router, private registro:Registro){ 
      this.form = this.fb.group({
        usuario:['', Validators.required],
        password:['', Validators.required],
        nombre:['', Validators.required],
        correo:['', Validators.required],
        telefono:['', Validators.required],
        razonSocial:['', Validators.required],
        cargo:['', Validators.required]
        
      })
      this.loading=false;
    }

    ngOnInit(): void {
      
    }

    async registrar(){
      const datosUser : RegistroRequest={
        Usuario:this.form.value.usuario,
        Contrasena:this.form.value.password,
        Nombre:this.form.value.nombre,
        CorreoElectronico:this.form.value.correo,
        Telefono:this.form.value.telefono,
        RazonSocial:this.form.value.razonSocial,
        Cargo:this.form.value.cargo
      }

      this.registro.createUser(datosUser)
      .subscribe({
        next:(response)=>{
          if(response!=null){
            console.log(response)
            if(response.message=="Exito"){
              this.router.navigate(['login'])
            }
            else{
              console.log("Ha ocurrido un error")
            }
          }
          else{
            console.log('Respuesta null')
          }
        },
        error:(error)=>{
          console.log(error);
        }

      })
    }
}
