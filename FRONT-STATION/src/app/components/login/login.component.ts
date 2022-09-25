import { Component, OnInit } from '@angular/core';
import { Auth } from 'src/app/class/Auth';
import { LoginService } from 'src/app/services/login.service';
import { Router} from '@angular/router'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  auth: Auth = new Auth()

  public showLoadinScreen: boolean = false
  public showMensageError: boolean = false;

  constructor(private loginService: LoginService, private route: Router) { }

  ngOnInit(): void {
  }


  SingUp():void{

    this.showLoadinScreen = true
    this.loginService.SingUp(this.auth)
      .then( Response => {
          this.route.navigate(["/dashboard"])
      })
      .catch(Error =>{
        this.showMensageError = true
        this.showLoadinScreen = false;
      })
      .finally()
  }
}
