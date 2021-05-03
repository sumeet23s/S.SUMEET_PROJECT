//
cc.Class({
    extends: cc.Component,

     properties: {
     
        cannon: {
            default: null,
            type: cc.Node
        }, 


    location : [cc.Node],

    

    index: number,

    bullet:{
    
    default:null,
    type: cc.Prefab,
     
    },

    },



    shoot:function () {



    switch (index){

    case 0:


    var newbullet = cc.instantiate(this.bullet);
    newbullet.setPosition(this.location[0].position.x, this.location[0].position.y-100);

    this.node.addChild(newbullet);
    this._timer=0.0;
    break;
    
    case 1:

    var newbullet = cc.instantiate(this.bullet);
    newbullet.setPosition(this.location[1].position.x, this.location[1].position.y-100);

    this.node.addChild(newbullet);
    this._timer=0.0;

    break;

    case 2:
   
    var newbullet = cc.instantiate(this.bullet);
    newbullet.setPosition(this.location[2].position.x, this.location[2].position.y-100);

    this.node.addChild(newbullet);
    this._timer=0.0;

    break;


    
    }
    },

     update :function (dt) {
     
     if(this.cannon.active == false){

     this._timer +=dt;


    if(this._timer >=2.0){


    index = Math.floor(Math.random() * (3-0)+ 0);
    
     

     if(this.location[index].active ){
     
     
    
     console.log(index);
     console.log(this.location[index].active);
    
     this.shoot();
     
    
     }
     
    else{

   
    if( this.location[0].active == false && this.location[1].active == false && this.location[2].active == false   ){

    console.log("tank destroyed");
    
    this.node.destroy();
     }
    

    
     }

     }

     }
     },

     
     start :function(){
    this._timer=0.0;

     },
        







});
