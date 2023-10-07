Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports Remix.Contracts.RockPaperScissors.ContractDefinition
Namespace Remix.Contracts.RockPaperScissors


    Public Partial Class RockPaperScissorsService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal rockPaperScissorsDeployment As RockPaperScissorsDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of RockPaperScissorsDeployment)().SendRequestAndWaitForReceiptAsync(rockPaperScissorsDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal rockPaperScissorsDeployment As RockPaperScissorsDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of RockPaperScissorsDeployment)().SendRequestAsync(rockPaperScissorsDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal rockPaperScissorsDeployment As RockPaperScissorsDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of RockPaperScissorsService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, rockPaperScissorsDeployment, cancellationTokenSource)
            Return New RockPaperScissorsService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function GetRandomChoiceQueryAsync(ByVal getRandomChoiceFunction As GetRandomChoiceFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            Return ContractHandler.QueryAsync(Of GetRandomChoiceFunction, Byte)(getRandomChoiceFunction, blockParameter)
        
        End Function

        
        Public Function GetRandomChoiceQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            return ContractHandler.QueryAsync(Of GetRandomChoiceFunction, Byte)(Nothing, blockParameter)
        
        End Function



        Public Function MinimumBetQueryAsync(ByVal minimumBetFunction As MinimumBetFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of MinimumBetFunction, BigInteger)(minimumBetFunction, blockParameter)
        
        End Function

        
        Public Function MinimumBetQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of MinimumBetFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function OwnerQueryAsync(ByVal ownerFunction As OwnerFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of OwnerFunction, String)(ownerFunction, blockParameter)
        
        End Function

        
        Public Function OwnerQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of OwnerFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function PlayRequestAsync(ByVal playFunction As PlayFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of PlayFunction)(playFunction)
        
        End Function

        Public Function PlayRequestAndWaitForReceiptAsync(ByVal playFunction As PlayFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of PlayFunction)(playFunction, cancellationToken)
        
        End Function

        
        Public Function PlayRequestAsync(ByVal [playerChoice] As Byte) As Task(Of String)
        
            Dim playFunction = New PlayFunction()
                playFunction.PlayerChoice = [playerChoice]
            
            Return ContractHandler.SendRequestAsync(Of PlayFunction)(playFunction)
        
        End Function

        
        Public Function PlayRequestAndWaitForReceiptAsync(ByVal [playerChoice] As Byte, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim playFunction = New PlayFunction()
                playFunction.PlayerChoice = [playerChoice]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of PlayFunction)(playFunction, cancellationToken)
        
        End Function
        Public Function RandomChoiceQueryAsync(ByVal randomChoiceFunction As RandomChoiceFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            Return ContractHandler.QueryAsync(Of RandomChoiceFunction, Byte)(randomChoiceFunction, blockParameter)
        
        End Function

        
        Public Function RandomChoiceQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            return ContractHandler.QueryAsync(Of RandomChoiceFunction, Byte)(Nothing, blockParameter)
        
        End Function



        Public Function SetMinimumBetRequestAsync(ByVal setMinimumBetFunction As SetMinimumBetFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetMinimumBetFunction)(setMinimumBetFunction)
        
        End Function

        Public Function SetMinimumBetRequestAndWaitForReceiptAsync(ByVal setMinimumBetFunction As SetMinimumBetFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetMinimumBetFunction)(setMinimumBetFunction, cancellationToken)
        
        End Function

        
        Public Function SetMinimumBetRequestAsync(ByVal [minimumBet] As BigInteger) As Task(Of String)
        
            Dim setMinimumBetFunction = New SetMinimumBetFunction()
                setMinimumBetFunction.MinimumBet = [minimumBet]
            
            Return ContractHandler.SendRequestAsync(Of SetMinimumBetFunction)(setMinimumBetFunction)
        
        End Function

        
        Public Function SetMinimumBetRequestAndWaitForReceiptAsync(ByVal [minimumBet] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim setMinimumBetFunction = New SetMinimumBetFunction()
                setMinimumBetFunction.MinimumBet = [minimumBet]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetMinimumBetFunction)(setMinimumBetFunction, cancellationToken)
        
        End Function
    
    End Class

End Namespace
