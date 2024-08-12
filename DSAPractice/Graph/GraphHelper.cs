namespace DSAPractice.Graph{

    public class GraphHelper{

        //  0 ------- 1
        //  |         |  \
        //  |         |    4
        //  |         |  /
        //  2 ------- 3  
        public void GetUGraphAN1(out int n, out List<int>[] adjacentNodes){
            n = 5;
            adjacentNodes = new List<int>[n];

            adjacentNodes[0] = new List<int>(){1,2};
            adjacentNodes[1] = new List<int>(){0,3,4};
            adjacentNodes[2] = new List<int>(){0,3};
            adjacentNodes[3] = new List<int>(){1,2,4};
            adjacentNodes[4] = new List<int>(){1,3};
        }

        //  0 ------- 1
        //  |         |  \
        //  |         |    4
        //  |         |  /
        //  2 ------- 3  
        public void GetUGraphM1(out int n, out int[,] adjacencyMatrix){
            n = 5;
            adjacencyMatrix = new int[n,n];

            adjacencyMatrix[0,1] = 1;
            adjacencyMatrix[1,0] = 1;
            adjacencyMatrix[0,2] = 1;
            adjacencyMatrix[2,0] = 1;
            adjacencyMatrix[2,3] = 1;
            adjacencyMatrix[3,2] = 1;

            adjacencyMatrix[3,1] = 1;
            adjacencyMatrix[1,3] = 1;
            adjacencyMatrix[4,3] = 1;
            adjacencyMatrix[3,4] = 1;
            adjacencyMatrix[4,1] = 1;
            adjacencyMatrix[1,4] = 1;

        }
    }
}