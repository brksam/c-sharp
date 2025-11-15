namespace Course {
    class ex6 {
        public static void Run(){
            string[] v = (Console.ReadLine() ?? "").Split(" ");

            int horaInicial = int.Parse(v[0]);
            int horaFinal = int.Parse(v[1]);

            int duracao;

            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else if (horaInicial == horaFinal) {
                duracao = 24;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }
            System.Console.WriteLine($"O jogo durou: {duracao} horas" );
        }
    }
}