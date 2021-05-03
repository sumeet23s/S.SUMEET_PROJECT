
cc.Class({
    extends: cc.Component,

        properties: {
     
        

        score: {
            default: null,
            type: cc.Node
        }

        
    },

    onLoad : function() {
     
     var manager = cc.director.getCollisionManager();
     manager.enabled = true;
     manager.enabledDrawBoundingBox = true;
     },
 
 
     onCollisionEnter :function (other, self) {

     this.score.getComponent('score').score +=1;
 
    
    
    this.node.destroy();
 

 
    },

     update (dt) {},
});
