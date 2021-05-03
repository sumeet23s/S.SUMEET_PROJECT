

cc.Class({
    extends: cc.Component,

    properties: {
 
  
    speed:number = 0,

    
    },

        onKeyDown(event){
    switch(event.keyCode){
     case cc.macro.KEY.a:
          this.accLeft = true;
          
          break;
     case cc.macro.KEY.d:
          this.accRight = true;
          break;
    }
    },

    onKeyUp(event){
    switch(event.keyCode){
     case cc.macro.KEY.a:
          this.accLeft = false;
          break;
     case cc.macro.KEY.d:
          this.accRight = false;
          break;
    }
    },

        start () {


        this._timer= 0.0;
    },


    onLoad : function() {
        cc.systemEvent.on(cc.SystemEvent.EventType.KEY_DOWN, this.onKeyDown, this);
        cc.systemEvent.on(cc.SystemEvent.EventType.KEY_UP, this.onKeyUp, this);
    
          this.accLeft = false;
  this.accRight = false;
    },

 

  update : function(dt) {

 this._timer +=dt;
  if(this.accLeft && this.node.x >= -444)
  {
 this.node.x -=this.speed*dt;

    }
    if(this.accRight && this.node.x <= 436){
    this.node.x +=this.speed*dt;
 
    }

   

  },





});
