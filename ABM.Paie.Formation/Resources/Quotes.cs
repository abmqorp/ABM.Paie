using Common.Models;

namespace ABM.Paie.Formation.Resources;

public static class Quotes
{
    private static readonly IEnumerable<QuoteModel> List = [
        new("Gustave Thibon", "Rien ne prédispose plus au conformisme que le manque de formation."),
        new("Socrate", "Le savoir est la seule matière qui s'accroit avec le partage."),
        new("Proverbe chinois", "L'apprentissage est un trésor qui suivra son propriétaire partout."),
        new("Benjamin Franklin", "Tu me dis, j'oublie. Tu m'enseignes, je me souviens. Tu m'impliques, j'apprends."),
        new("Claude Bernard", "C'est ce que nous pensons déjà connaître qui nous empêche souvent d'apprendre."),
        new("Proverbe japonais", "On commence à vieillir quand on finit d'apprendre."),
        new("Proverbe danois", "Qui a peur de poser des questions a honte d'apprendre."),
        new("Pierre de Coubertin", "Chaque difficulté rencontrée doit être l'occasion d'un nouveau progrès."),
        new("Proverbe japonais", "On ne vide pas l'océan avec un coquillage."),
        new("Socrate", "Le secret du changement, c'est de concentrer toute notre énergie non pas à lutter contre le passé mais à construire l'avenir."),
        new("Proverbe néerlandais", "Un bon maçon ne rejette aucune pierre."),
        new("Winston Churchill", "Le chemin du succès se bâtit sur une série d'échecs sans perdre son enthousiasme."),
        new("Antoine de Saint-Exupéry", "La vérité de demain se nourrit de l'erreur d'hier."),
        new("George Sand", "Les chefs-d'œuvre ne sont jamais que des tentatives heureuses."),
        new("Marie Curie", "Dans la vie rien n'est à craindre tout est à comprendre."),
        new("Proverbe chinois", "Ne craignez pas d'être lent, craignez seulement d'être à l'arrêt."),
        new("José Maria Eça de Queiros", "La curiosité mène à tout : parfois à écouter aux portes, parfois à découvrir l'Amérique."),
        new("Ray Kroc", "Si vous pensez que la formation coûte cher, songez au prix de l'ignorance."),
        new("Jeremy Rifkin", "Nous nous voyons comme des oeuvres d'art inachevées. Nous passons de plus en plus de temps à corriger, à améliorer notre corps. Nous sommes toujours en formation, jamais finis."),
        new("Zineve", "Le sens de la vie c'est apprendre toujours, apprendre et transmettre parce que transmettre c'est donner, donner c'est aider, aider c'est avancer, avancer c'est grandir."),
        new("Pablo Picasso", "J'essaie toujours de faire ce que je ne sais pas faire, c'est ainsi que j'espère apprendre à le faire."),
        new("Amadou-hampâté-bâ", "Ne regrette rien, il faudra toujours continuer à apprendre et à te perfectionner, et ce n'est pas à l'école que tu pourras le faire. L'école donne des diplômes, mais c'est dans la vie qu'on se forme."),
        new("Jiddu-krishnamurti", "La véritable éducation, c'est d'apprendre comment penser, et non pas quoi penser."),
        new("Winston Churchill", "Je suis toujours prêt à apprendre, bien que je n'aime pas toujours qu'on me donne des leçons."),
        new("Aristote", "Ce que nous devons apprendre à faire, nous l'apprendrons en le faisant."),
        new("Narada", "Il faut apprendre pour connaître, connaître pour comprendre, comprendre pour juger."),
        new("Charlie Chaplin", "Il faut apprendre, non pas pour l'amour de la connaissance, mais pour se défendre contre le mépris dans lequel le monde tient les ignorants."),
        new("Dalaï-lama Tenzin-Gyatso", "Quand tu parles, tu ne fais que répéter ce que tu sais. Mais quand tu écoutes, tu peux apprendre quelque chose de nouveau."),
        new("Confucius", "Celui qui aime à apprendre est bien près du savoir."),
        new("Sultan Valad", "Il est impossible d'apprendre un métier tout seul. Une bougie s'allume au contact de la flamme d'une autre bougie. Si elle ne s'en approche pas elle restera éteinte."),
    ];

    public static IEnumerable<QuoteModel> GetAll() => List;
}
