
cc.Class({
    extends: cc.Component,

    properties: {
        
    hiteffect :{

    default: null,
    type: cc.Prefab,
    },


    },

    
     onLoad : function() {
     
     var manager = cc.director.getCollisionManager();
     manager.enabled = true;
     manager.enabledDrawBoundingBox = true;


     },


     onCollisionEnter :function (other, self) {
     
   
    this.node.destroy();

    

    },
     
     
 

    start () {


    },

    update (dt) {
    
    this._timer +=dt;
    
    },

});
