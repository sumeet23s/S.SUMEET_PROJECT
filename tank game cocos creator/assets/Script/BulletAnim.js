
cc.Class({
    extends: cc.Component, 

    properties: {

    speed:number = 250,

    check :false,

    },


     onLoad : function(){

     var manager = cc.director.getCollisionManager();
     manager.enabled = true;
     manager.enabledDrawBoundingBox = true;
      
     },



    onCollisionEnter : function  (other, self) {

   
    
    this.node.getChildByName("bullet").active = false;
    this.node.getChildByName("Hiteffect").active = true;

    this.speed = 0;

   // this.node.destroy();


   

    },




    update : function(dt){

    this.node.y += this.speed*dt;
    

   },

});
