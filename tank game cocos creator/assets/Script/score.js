
cc.Class({
    extends: cc.Component,

    properties: {

   score :number =0,

   scorelabel : {

    default : null,
    type :cc.Label,

    }



    },




    start () {

    },

   


     update (dt) {
     
       this.scorelabel.string ='SCORE :' +this.score.toString();
     
     },



});
