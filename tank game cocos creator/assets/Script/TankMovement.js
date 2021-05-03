
cc.Class({
    extends: cc.Component,

    properties: {
        

    cannon: {
            default: null,
            type: cc.Node
        },


     speed : 0,
      },
 
   
 
   onLoad () {
   
  
   
   },
 
    start () {
    this._timer = 0.0;
    },
 

   update (dt) {

   if(this.cannon.active == false){

   this._timer += dt;
 
 
       if ( this._timer >= 2.0 && this._timer <= 9.0) {
this.node.x -=this.speed*dt;
    }
 
       if ( this._timer >=9.0 && this._timer<=24.0) {
this.node.x +=this.speed*dt;
    }
 
    if (  this._timer>=24.0) {
this.node.y -=this.speed*dt;
    }
 
   

    }
   },

 


  



 
});
